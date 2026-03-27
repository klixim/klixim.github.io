using Practice_Task_6.Models;
using System.Collections.Generic;

namespace Practice_Task_6.Models
{
    public class Theme
    {
        public string Name { get; set; }
        public List<Level> Levels { get; set; }

        public Theme()
        {
            Name = string.Empty;
            Levels = new List<Level>();
        }

        public Level GetLevel(int difficulty)
        {
            return Levels.Find(l => l.Difficulty == difficulty);
        }

        public bool IsLevelUnlocked(int level, int bestScore)
        {
            if (level == 1) return true;
            return bestScore >= 80;
        }
    }
}