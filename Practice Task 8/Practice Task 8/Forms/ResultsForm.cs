using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PracticeTask8
{
    public partial class ResultsForm : Form
    {
        private string currentUser;

        public ResultsForm(string login)
        {
            currentUser = login;
            InitializeComponent();
            lblUser.Text = $"Игрок: {currentUser}";
            LoadResults();
        }

        private void LoadResults()
        {
            const string resultsFile = "results.dat";
            List<GameResult> allResults = new List<GameResult>();

            if (File.Exists(resultsFile))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(resultsFile, FileMode.Open))
                    {
                        allResults = (List<GameResult>)formatter.Deserialize(fs);
                    }
                }
                catch { }
            }

            var userResults = allResults.FindAll(r => r.UserLogin == currentUser);
            userResults.Sort((a, b) => b.GameDate.CompareTo(a.GameDate));

            dgvResults.Rows.Clear();

            if (userResults.Count == 0)
            {
                dgvResults.Rows.Add("", "", "", "", "", "Нет сохранённых результатов");
                return;
            }

            foreach (var result in userResults)
            {
                dgvResults.Rows.Add(
                    result.GameDate.ToString("dd.MM.yyyy HH:mm"),
                    result.CorrectAnswers,
                    result.TotalQuestions,
                    $"{result.Percentage:F1}%",
                    result.Grade,
                    result.Comment
                );
            }

            if (userResults.Count > 0)
            {
                double avgPercent = 0;
                int totalGames = userResults.Count;

                foreach (var r in userResults)
                {
                    avgPercent += r.Percentage;
                }
                avgPercent /= totalGames;

                this.Text = $"Мои результаты - Игрок: {currentUser} (Игр: {totalGames}, Средний %: {avgPercent:F1}%)";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            saveDialog.DefaultExt = "txt";
            saveDialog.FileName = $"results_{currentUser}_{DateTime.Now:yyyyMMdd_HHmmss}";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine($"Результаты игрока: {currentUser}");
                        writer.WriteLine($"Дата экспорта: {DateTime.Now}");
                        writer.WriteLine(new string('-', 80));
                        writer.WriteLine();

                        for (int i = 0; i < dgvResults.Rows.Count; i++)
                        {
                            if (dgvResults.Rows[i].Cells[0].Value != null && dgvResults.Rows[i].Cells[0].Value.ToString() != "")
                            {
                                writer.WriteLine($"Дата: {dgvResults.Rows[i].Cells[0].Value}");
                                writer.WriteLine($"Результат: {dgvResults.Rows[i].Cells[1].Value}/{dgvResults.Rows[i].Cells[2].Value}");
                                writer.WriteLine($"Процент: {dgvResults.Rows[i].Cells[3].Value}");
                                writer.WriteLine($"Оценка: {dgvResults.Rows[i].Cells[4].Value}");
                                writer.WriteLine($"Комментарий: {dgvResults.Rows[i].Cells[5].Value}");
                                writer.WriteLine(new string('-', 40));
                            }
                        }
                    }

                    MessageBox.Show($"Результаты экспортированы в файл:\n{saveDialog.FileName}",
                        "Экспорт выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}