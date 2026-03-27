using Practice_Task_6.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Practice_Task_6.Forms
{
    public partial class GameForm : Form
    {
        private List<InventionQuestion> currentQuestions;
        private int currentIndex;
        private int score;
        private int totalQuestions;
        private int questionsPerSession = 5;
        private Random random = new Random();
        private string themeName;
        private int currentLevel;
        private int timeRemaining;
        private Timer gameTimer;
        private bool isAnswered;

        public int FinalScore => score;
        public bool LevelCompleted => score >= 80;

        public GameForm(string theme, int level, List<InventionQuestion> questions)
        {
            InitializeComponent();
            themeName = theme;
            currentLevel = level;
            currentQuestions = questions.OrderBy(x => random.Next()).Take(questionsPerSession).ToList();
            totalQuestions = currentQuestions.Count;
            currentIndex = 0;
            score = 0;
            isAnswered = false;

            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Text = $"Викторина: {themeName} - Уровень {currentLevel}";
            lblScore.Text = "Счёт: 0";
            lblQuestionCounter.Text = $"Вопрос 1 из {totalQuestions}";

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            LoadCurrentQuestion();
        }

        private void LoadCurrentQuestion()
        {
            if (currentIndex >= totalQuestions)
            {
                EndGame();
                return;
            }

            isAnswered = false;
            gameTimer.Stop();
            timeRemaining = 30;
            lblTimer.Text = $"Время: {timeRemaining} сек";
            gameTimer.Start();

            var question = currentQuestions[currentIndex];
            lblQuestion.Text = $"Кто изобрёл: {question.InventionName}?";

            // Загрузка изображения
            try
            {
                if (!string.IsNullOrEmpty(question.ImagePath) && System.IO.File.Exists(question.ImagePath))
                {
                    pictureBox.Image = Image.FromFile(question.ImagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox.Image = null;
                    pictureBox.BackColor = SystemColors.ControlLight;
                }
            }
            catch
            {
                pictureBox.Image = null;
            }

            // Загрузка вариантов ответов
            var answers = question.Answers.OrderBy(x => random.Next()).ToList();

            radioButton1.Text = answers[0].Text;
            radioButton2.Text = answers[1].Text;
            radioButton3.Text = answers[2].Text;
            radioButton4.Text = answers[3].Text;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            btnAnswer.Enabled = true;

            // Подсказка
            lblHint.Text = question.Hint;
            lblHint.Visible = false;

            lblQuestionCounter.Text = $"Вопрос {currentIndex + 1} из {totalQuestions}";
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            lblTimer.Text = $"Время: {timeRemaining} сек";

            if (timeRemaining <= 0)
            {
                gameTimer.Stop();
                if (!isAnswered)
                {
                    MessageBox.Show("Время вышло! Переход к следующему вопросу.", "Время истекло",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NextQuestion();
                }
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (isAnswered) return;

            RadioButton selectedRadio = null;
            if (radioButton1.Checked) selectedRadio = radioButton1;
            else if (radioButton2.Checked) selectedRadio = radioButton2;
            else if (radioButton3.Checked) selectedRadio = radioButton3;
            else if (radioButton4.Checked) selectedRadio = radioButton4;

            if (selectedRadio == null)
            {
                MessageBox.Show("Выберите вариант ответа!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gameTimer.Stop();
            isAnswered = true;

            var question = currentQuestions[currentIndex];
            var correctAnswer = question.GetCorrectAnswer();

            if (selectedRadio.Text == correctAnswer.Text)
            {
                int points = 100 / totalQuestions;
                score += points;
                MessageBox.Show($"Правильно! +{points} баллов", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Неправильно! Правильный ответ: {correctAnswer.Text}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblScore.Text = $"Счёт: {score}";

            NextQuestion();
        }

        private void NextQuestion()
        {
            currentIndex++;
            if (currentIndex < totalQuestions)
            {
                LoadCurrentQuestion();
            }
            else
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();

            string message = $"Игра завершена!\n\nВаш счёт: {score} из 100\n";
            if (score >= 80)
            {
                message += "\nПоздравляем! Вы набрали достаточно баллов для перехода на следующий уровень!";
            }
            else
            {
                message += $"\nВам не хватает {80 - score} баллов для перехода на следующий уровень.";
            }

            MessageBox.Show(message, "Результат игры", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHint.Visible = true;
            btnHint.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти в главное меню? Прогресс будет потерян.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gameTimer.Stop();
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            gameTimer?.Stop();
            base.OnFormClosing(e);
        }
    }
}