using Practice_Task_6.Models;
using System.Collections.Generic;

namespace Practice_Task_6.Models
{
    public class Level
    {
        public int Difficulty { get; set; }
        public List<InventionQuestion> Questions { get; set; }

        public Level()
        {
            Difficulty = 1;
            Questions = new List<InventionQuestion>();
        }
    }
}