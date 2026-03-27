using Practice_Task_6.Services;
using Practice_Task_6.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practice_Task_6.Forms
{
    public partial class AdminForm : Form
    {
        private List<Theme> themes;
        private XmlLoader xmlLoader;
        private XmlWriterHelper xmlWriter;
        private string xmlPath = "inventions.xml";
        private int selectedThemeIndex;
        private int selectedLevel;
        private int selectedQuestionIndex;

        public AdminForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            xmlLoader = new XmlLoader(xmlPath);
            xmlWriter = new XmlWriterHelper(xmlPath);
            themes = xmlLoader.LoadThemes();

            UpdateThemeList();
        }

        private void UpdateThemeList()
        {
            lstThemes.Items.Clear();
            foreach (var theme in themes)
            {
                lstThemes.Items.Add(theme.Name);
            }

            if (lstThemes.Items.Count > 0)
            {
                lstThemes.SelectedIndex = 0;
            }
        }

        private void lstThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstThemes.SelectedIndex >= 0)
            {
                selectedThemeIndex = lstThemes.SelectedIndex;
                UpdateLevelList();
            }
        }

        private void UpdateLevelList()
        {
            lstLevels.Items.Clear();
            if (selectedThemeIndex < themes.Count)
            {
                var theme = themes[selectedThemeIndex];
                for (int i = 1; i <= 3; i++)
                {
                    string status = theme.GetLevel(i) != null ? " (существует)" : " (не создан)";
                    lstLevels.Items.Add($"Уровень {i}{status}");
                }
            }

            if (lstLevels.Items.Count > 0)
            {
                lstLevels.SelectedIndex = 0;
            }
        }

        private void lstLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLevels.SelectedIndex >= 0)
            {
                selectedLevel = lstLevels.SelectedIndex + 1;
                UpdateQuestionsList();
                ClearInputFields();
            }
        }

        private void UpdateQuestionsList()
        {
            lstQuestions.Items.Clear();
            if (selectedThemeIndex < themes.Count)
            {
                var theme = themes[selectedThemeIndex];
                var level = theme.GetLevel(selectedLevel);
                if (level != null)
                {
                    for (int i = 0; i < level.Questions.Count; i++)
                    {
                        lstQuestions.Items.Add($"{i + 1}. {level.Questions[i].InventionName}");
                    }
                }
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex >= 0)
            {
                selectedQuestionIndex = lstQuestions.SelectedIndex;
                LoadQuestionToInput();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                ClearInputFields();
            }
        }

        private void LoadQuestionToInput()
        {
            if (selectedThemeIndex < themes.Count)
            {
                var theme = themes[selectedThemeIndex];
                var level = theme.GetLevel(selectedLevel);
                if (level != null && selectedQuestionIndex < level.Questions.Count)
                {
                    var q = level.Questions[selectedQuestionIndex];
                    txtInvention.Text = q.InventionName;
                    txtImagePath.Text = q.ImagePath;
                    txtHint.Text = q.Hint;

                    // Загрузка ответов
                    var answers = q.Answers.OrderBy(a => a.IsCorrect ? 0 : 1).ToList();
                    if (answers.Count >= 4)
                    {
                        txtAnswer1.Text = answers[0].Text;
                        chkCorrect1.Checked = answers[0].IsCorrect;
                        txtAnswer2.Text = answers[1].Text;
                        chkCorrect2.Checked = answers[1].IsCorrect;
                        txtAnswer3.Text = answers[2].Text;
                        chkCorrect3.Checked = answers[2].IsCorrect;
                        txtAnswer4.Text = answers[3].Text;
                        chkCorrect4.Checked = answers[3].IsCorrect;
                    }

                    // Загрузка изображения
                    if (!string.IsNullOrEmpty(q.ImagePath) && File.Exists(q.ImagePath))
                    {
                        pictureBox.Image = Image.FromFile(q.ImagePath);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                }
            }
        }

        private void ClearInputFields()
        {
            txtInvention.Text = "";
            txtImagePath.Text = "";
            txtHint.Text = "";
            txtAnswer1.Text = "";
            txtAnswer2.Text = "";
            txtAnswer3.Text = "";
            txtAnswer4.Text = "";
            chkCorrect1.Checked = false;
            chkCorrect2.Checked = false;
            chkCorrect3.Checked = false;
            chkCorrect4.Checked = false;
            pictureBox.Image = null;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtInvention.Text))
            {
                MessageBox.Show("Введите название изобретения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAnswer1.Text) ||
                string.IsNullOrWhiteSpace(txtAnswer2.Text) ||
                string.IsNullOrWhiteSpace(txtAnswer3.Text) ||
                string.IsNullOrWhiteSpace(txtAnswer4.Text))
            {
                MessageBox.Show("Заполните все варианты ответов!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int correctCount = (chkCorrect1.Checked ? 1 : 0) +
                               (chkCorrect2.Checked ? 1 : 0) +
                               (chkCorrect3.Checked ? 1 : 0) +
                               (chkCorrect4.Checked ? 1 : 0);

            if (correctCount != 1)
            {
                MessageBox.Show("Должен быть ровно один правильный ответ!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private InventionQuestion GetQuestionFromInput()
        {
            var question = new InventionQuestion
            {
                InventionName = txtInvention.Text,
                ImagePath = txtImagePath.Text,
                Hint = txtHint.Text
            };

            question.Answers.Add(new Answer(txtAnswer1.Text, chkCorrect1.Checked));
            question.Answers.Add(new Answer(txtAnswer2.Text, chkCorrect2.Checked));
            question.Answers.Add(new Answer(txtAnswer3.Text, chkCorrect3.Checked));
            question.Answers.Add(new Answer(txtAnswer4.Text, chkCorrect4.Checked));

            return question;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (selectedThemeIndex >= themes.Count)
            {
                MessageBox.Show("Выберите тему!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var theme = themes[selectedThemeIndex];
            var question = GetQuestionFromInput();

            xmlWriter.AddQuestionToTheme(theme.Name, selectedLevel, question);
            LoadData();

            // Выбрать созданный уровень
            lstLevels.SelectedIndex = selectedLevel - 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (selectedQuestionIndex < 0) return;

            var theme = themes[selectedThemeIndex];
            var question = GetQuestionFromInput();

            xmlWriter.UpdateQuestion(theme.Name, selectedLevel, selectedQuestionIndex, question);
            LoadData();

            lstLevels.SelectedIndex = selectedLevel - 1;
            if (lstQuestions.Items.Count > selectedQuestionIndex)
            {
                lstQuestions.SelectedIndex = selectedQuestionIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedQuestionIndex < 0) return;

            if (MessageBox.Show("Вы уверены, что хотите удалить этот вопрос?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var theme = themes[selectedThemeIndex];
                xmlWriter.DeleteQuestion(theme.Name, selectedLevel, selectedQuestionIndex);
                LoadData();
                lstLevels.SelectedIndex = selectedLevel - 1;
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Выберите изображение изобретения";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                    try
                    {
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось загрузить изображение!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCreateTheme_Click(object sender, EventArgs e)
        {
            string newThemeName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название новой темы (века):",
                "Создание темы",
                "XX век");

            if (!string.IsNullOrWhiteSpace(newThemeName))
            {
                // Проверить, существует ли уже такая тема
                if (themes.Any(t => t.Name == newThemeName))
                {
                    MessageBox.Show("Такая тема уже существует!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создать новую тему с пустыми уровнями
                for (int level = 1; level <= 3; level++)
                {
                    var dummyQuestion = new InventionQuestion
                    {
                        InventionName = "Пример изобретения",
                        ImagePath = "",
                        Hint = "Это пример вопроса. Отредактируйте или удалите его."
                    };
                    dummyQuestion.Answers.Add(new Answer("Правильный ответ", true));
                    dummyQuestion.Answers.Add(new Answer("Неправильный ответ 1", false));
                    dummyQuestion.Answers.Add(new Answer("Неправильный ответ 2", false));
                    dummyQuestion.Answers.Add(new Answer("Неправильный ответ 3", false));

                    xmlWriter.AddQuestionToTheme(newThemeName, level, dummyQuestion);
                }

                LoadData();
                MessageBox.Show("Тема успешно создана!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}