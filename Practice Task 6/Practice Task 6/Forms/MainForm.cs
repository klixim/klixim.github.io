using Practice_Task_6.Forms;
using Practice_Task_6.Models;
using Practice_Task_6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Practice_Task_6.Forms
{
    public partial class MainForm : Form
    {
        private List<Theme> themes;
        private XmlLoader xmlLoader;
        private string xmlPath = "inventions.xml";
        private int[] bestScores; // Лучшие результаты по уровням для каждой темы
        private string currentTheme;
        private int currentLevel = 1;

        public MainForm()
        {
            InitializeComponent();
            InitializeBestScores();
            LoadThemes();
        }

        private void InitializeBestScores()
        {
            bestScores = new int[4]; // Индексы 1-3 для уровней
            for (int i = 1; i <= 3; i++)
            {
                bestScores[i] = 0;
            }
        }

        private void LoadThemes()
        {
            xmlLoader = new XmlLoader(xmlPath);

            if (!xmlLoader.ValidateXml())
            {
                MessageBox.Show("XML файл не найден или поврежден. Создайте новый через панель администратора.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CreateDefaultXml();
                xmlLoader = new XmlLoader(xmlPath);
            }

            themes = xmlLoader.LoadThemes();

            cmbTheme.Items.Clear();
            foreach (var theme in themes)
            {
                cmbTheme.Items.Add(theme.Name);
            }

            if (cmbTheme.Items.Count > 0)
            {
                cmbTheme.SelectedIndex = 0;
            }

            UpdateLevelButtons();
        }

        private void CreateDefaultXml()
        {
            var writer = new XmlWriterHelper(xmlPath);

            // Создать примеры вопросов для XVIII века
            var exampleQuestion = new InventionQuestion
            {
                InventionName = "Паровой двигатель",
                ImagePath = "images/steam_engine.jpg",
                Hint = "Усовершенствовал паровую машину в 1776 году, что дало начало промышленной революции."
            };
            exampleQuestion.Answers.Add(new Answer("Ньюкомен", false));
            exampleQuestion.Answers.Add(new Answer("Джеймс Уатт", true));
            exampleQuestion.Answers.Add(new Answer("Томас Эдисон", false));
            exampleQuestion.Answers.Add(new Answer("Никола Тесла", false));

            writer.AddQuestionToTheme("XVIII век", 1, exampleQuestion);

            var exampleQuestion2 = new InventionQuestion
            {
                InventionName = "Телефон",
                ImagePath = "images/telephone.jpg",
                Hint = "Патент на это изобретение был получен в 1876 году."
            };
            exampleQuestion2.Answers.Add(new Answer("Александр Белл", true));
            exampleQuestion2.Answers.Add(new Answer("Томас Эдисон", false));
            exampleQuestion2.Answers.Add(new Answer("Гульельмо Маркони", false));
            exampleQuestion2.Answers.Add(new Answer("Александр Попов", false));

            writer.AddQuestionToTheme("XIX век", 1, exampleQuestion2);

            themes = xmlLoader.LoadThemes();
        }

        private void UpdateLevelButtons()
        {
            if (cmbTheme.SelectedIndex >= 0 && cmbTheme.SelectedIndex < themes.Count)
            {
                var theme = themes[cmbTheme.SelectedIndex];

                btnLevel1.Enabled = true;
                btnLevel2.Enabled = theme.IsLevelUnlocked(2, bestScores[1]);
                btnLevel3.Enabled = theme.IsLevelUnlocked(3, bestScores[2]);

                string scoreText = bestScores[1] > 0 ? $" (лучший: {bestScores[1]}%)" : "";
                btnLevel2.Text = $"Уровень 2{scoreText}";

                scoreText = bestScores[2] > 0 ? $" (лучший: {bestScores[2]}%)" : "";
                btnLevel3.Text = $"Уровень 3{scoreText}";
            }
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTheme = cmbTheme.SelectedItem?.ToString();
            UpdateLevelButtons();
        }

        private void StartGame(int level)
        {
            if (cmbTheme.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите тему!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var theme = themes[cmbTheme.SelectedIndex];
            var levelData = theme.GetLevel(level);

            if (levelData == null || levelData.Questions.Count == 0)
            {
                MessageBox.Show($"В выбранном уровне нет вопросов. Добавьте вопросы через панель администратора.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var gameForm = new GameForm(theme.Name, level, levelData.Questions);

            if (gameForm.ShowDialog() == DialogResult.OK)
            {
                // Обновить лучший результат
                if (gameForm.FinalScore > bestScores[level])
                {
                    bestScores[level] = gameForm.FinalScore;
                    UpdateLevelButtons();

                    if (gameForm.LevelCompleted && level < 3)
                    {
                        MessageBox.Show($"Поздравляем! Вы набрали {gameForm.FinalScore} баллов и разблокировали следующий уровень!",
                            "Уровень разблокирован", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateLevelButtons();
                    }
                }
            }
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            currentLevel = 1;
            StartGame(1);
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            if (btnLevel2.Enabled)
            {
                currentLevel = 2;
                StartGame(2);
            }
            else
            {
                MessageBox.Show("Этот уровень заблокирован. Наберите 80 баллов на предыдущем уровне.",
                    "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            if (btnLevel3.Enabled)
            {
                currentLevel = 3;
                StartGame(3);
            }
            else
            {
                MessageBox.Show("Этот уровень заблокирован. Наберите 80 баллов на предыдущем уровне.",
                    "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            adminForm.ShowDialog();
            LoadThemes(); // Перезагрузить темы после изменений
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}