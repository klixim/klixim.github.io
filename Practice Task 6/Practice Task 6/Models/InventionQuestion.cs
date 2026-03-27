using Practice_Task_6.Models;
using System.Collections.Generic;

namespace Practice_Task_6.Models
{
    public class InventionQuestion
    {
        public string InventionName { get; set; }
        public string ImagePath { get; set; }
        public List<Answer> Answers { get; set; }
        public string Hint { get; set; }

        public InventionQuestion()
        {
            InventionName = string.Empty;
            ImagePath = string.Empty;
            Answers = new List<Answer>();
            Hint = string.Empty;
        }

        public Answer GetCorrectAnswer()
        {
            return Answers.Find(a => a.IsCorrect);
        }

        public List<Answer> GetIncorrectAnswers()
        {
            return Answers.FindAll(a => !a.IsCorrect);
        }
    }
}