using System;

namespace PracticeTask8
{
    [Serializable]
    public class GameResult
    {
        public string UserLogin { get; set; }
        public DateTime GameDate { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
        public string Comment { get; set; }

        public GameResult()
        {
            GameDate = DateTime.Now;
        }

        public GameResult(string login, int total, int correct)
        {
            UserLogin = login;
            GameDate = DateTime.Now;
            TotalQuestions = total;
            CorrectAnswers = correct;
            Percentage = total > 0 ? (double)correct / total * 100 : 0;
            SetGradeAndComment();
        }

        private void SetGradeAndComment()
        {
            if (Percentage >= 90)
            {
                Grade = "5";
                Comment = "Отличный словарный запас!";
            }
            else if (Percentage >= 75)
            {
                Grade = "4";
                Comment = "Хороший словарный запас!";
            }
            else if (Percentage >= 60)
            {
                Grade = "3";
                Comment = "Недостаточный словарный запас";
            }
            else
            {
                Grade = "2";
                Comment = "Очень маленький словарный запас";
            }
        }

        public override string ToString()
        {
            return $"{GameDate:dd.MM.yyyy HH:mm} | Правильно: {CorrectAnswers}/{TotalQuestions} ({Percentage:F1}%) | Оценка: {Grade} | {Comment}";
        }
    }
}