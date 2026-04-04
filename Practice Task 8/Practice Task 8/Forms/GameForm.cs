using Practice_Task_8;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class GameForm : Form
    {
        private string currentUser;
        private GameData gameData;
        private Word currentWord;
        private int correctCount = 0;
        private int totalCount = 0;
        private int questionsPerGame = 10;

        public GameForm(string user, GameData data, int questions = 10)
        {
            currentUser = user;
            gameData = data;
            questionsPerGame = questions;
            InitializeComponent();
            progressLabel.Text = $"Вопрос: 0/{questionsPerGame}";
            LoadNextWord();
        }

        private void LoadNextWord()
        {
            if (totalCount >= questionsPerGame)
            {
                EndGame();
                return;
            }

            currentWord = gameData.GetRandomWord();
            if (currentWord == null)
            {
                MessageBox.Show("В словаре нет слов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            wordLabel.Text = currentWord.Term.ToUpper();
            answerTextBox.Clear();
            answerTextBox.Enabled = true;
            submitButton.Enabled = true;
            nextButton.Enabled = false;
            answerTextBox.Focus();

            progressLabel.Text = $"Вопрос: {totalCount + 1}/{questionsPerGame}";
            scoreLabel.Text = $"Правильно: {correctCount}/{totalCount}";

            pictureBox.Image = DrawNeutralFace();
        }

        private Image DrawHappyFace()
        {
            Bitmap bmp = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Yellow);
                g.FillEllipse(Brushes.Yellow, 0, 0, 150, 150);
                g.DrawEllipse(Pens.Black, 0, 0, 150, 150);
                g.FillEllipse(Brushes.Black, 35, 50, 15, 20);
                g.FillEllipse(Brushes.Black, 100, 50, 15, 20);
                g.DrawArc(Pens.Black, 35, 70, 80, 50, 0, -180);
            }
            return bmp;
        }

        private Image DrawSadFace()
        {
            Bitmap bmp = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Yellow);
                g.FillEllipse(Brushes.Yellow, 0, 0, 150, 150);
                g.DrawEllipse(Pens.Black, 0, 0, 150, 150);
                g.FillEllipse(Brushes.Black, 35, 50, 15, 20);
                g.FillEllipse(Brushes.Black, 100, 50, 15, 20);
                g.DrawArc(Pens.Black, 35, 90, 80, 50, 0, 180);
            }
            return bmp;
        }

        private Image DrawNeutralFace()
        {
            Bitmap bmp = new Bitmap(150, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.FillEllipse(Brushes.LightGray, 0, 0, 150, 150);
                g.DrawEllipse(Pens.Black, 0, 0, 150, 150);
                g.FillEllipse(Brushes.Black, 35, 50, 15, 20);
                g.FillEllipse(Brushes.Black, 100, 50, 15, 20);
                g.DrawLine(Pens.Black, 50, 100, 100, 100);
            }
            return bmp;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userAnswer = answerTextBox.Text.Trim();

            if (string.IsNullOrEmpty(userAnswer))
            {
                MessageBox.Show("Введите ответ!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isCorrect = currentWord.CheckSynonym(userAnswer);

            if (isCorrect)
            {
                correctCount++;
                pictureBox.Image = DrawHappyFace();
                MessageBox.Show("Правильно! ✓", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox.Image = DrawSadFace();
                MessageBox.Show($"Неправильно! ✗\n\nПравильные синонимы: {currentWord.GetSynonymsDisplay()}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            totalCount++;
            scoreLabel.Text = $"Правильно: {correctCount}/{totalCount}";

            answerTextBox.Enabled = false;
            submitButton.Enabled = false;
            nextButton.Enabled = true;
            nextButton.Focus();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            LoadNextWord();
        }

        private void EndGame()
        {
            GameResult result = new GameResult(currentUser, totalCount, correctCount);
            SaveResult(result);

            string message = $"Игра окончена!\n\n" +
                $"Правильных ответов: {correctCount} из {totalCount}\n" +
                $"Процент: {result.Percentage:F1}%\n" +
                $"Оценка: {result.Grade}\n\n" +
                $"{result.Comment}";

            MessageBox.Show(message, "Результаты игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SaveResult(GameResult result)
        {
            const string resultsFile = "results.dat";
            List<GameResult> results = new List<GameResult>();

            if (File.Exists(resultsFile))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(resultsFile, FileMode.Open))
                    {
                        results = (List<GameResult>)formatter.Deserialize(fs);
                    }
                }
                catch { }
            }

            results.Add(result);

            BinaryFormatter formatter2 = new BinaryFormatter();
            using (FileStream fs = new FileStream(resultsFile, FileMode.Create))
            {
                formatter2.Serialize(fs, results);
            }
        }
    }
}