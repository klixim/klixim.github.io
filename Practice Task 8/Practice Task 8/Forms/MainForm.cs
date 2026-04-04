using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class MainForm : Form
    {
        private string currentUser;
        private GameData gameData;

        public MainForm(string login)
        {
            currentUser = login;
            gameData = new GameData();
            InitializeComponent();
            userLabel.Text = $"Игрок: {currentUser}";
            pictureBox.Image = DrawHappyFace();
        }

        private Image DrawHappyFace()
        {
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Yellow);
                g.FillEllipse(Brushes.Yellow, 0, 0, 100, 100);
                g.DrawEllipse(Pens.Black, 0, 0, 100, 100);
                g.FillEllipse(Brushes.Black, 25, 35, 10, 15);
                g.FillEllipse(Brushes.Black, 65, 35, 10, 15);
                g.DrawArc(Pens.Black, 25, 45, 50, 35, 0, -180);
            }
            return bmp;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void startGameMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            if (gameData.Words.Count == 0)
            {
                MessageBox.Show("В словаре нет слов. Обратитесь к администратору.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int questions = SettingsForm.QuestionsPerGame;
            GameForm gameForm = new GameForm(currentUser, gameData, questions);
            gameForm.ShowDialog();
            pictureBox.Image = DrawHappyFace();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminMode();
        }

        private void adminMenuItem_Click(object sender, EventArgs e)
        {
            AdminMode();
        }

        private void AdminMode()
        {
            string password = Prompt.ShowDialog("Введите пароль администратора:", "Авторизация администратора");
            if (gameData.AdminLogin(password))
            {
                AdminForm adminForm = new AdminForm(gameData);
                adminForm.ShowDialog();
            }
            else if (!string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void resultsMenuItem_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void ShowResults()
        {
            ResultsForm resultsForm = new ResultsForm(currentUser);
            resultsForm.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра «Словарный запас» - Вариант 13\n\n" +
                "Правила:\n" +
                "Вам предлагается слово, к которому нужно подобрать синоним.\n" +
                "Правильные ответы сопровождаются веселой картинкой,\n" +
                "неправильные - грустной.\n\n" +
                "Режим администратора позволяет добавлять новые слова\n" +
                "и синонимы в словарь.\n\n" +
                "© 2024 Practice Task 8",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350, PasswordChar = '*' };
            Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}