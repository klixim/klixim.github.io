using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace PracticeTask8
{
    public class GameData
    {
        private const string WordsFile = "words.dat";
        private const string AdminPassword = "admin123";

        public List<Word> Words { get; set; }

        public GameData()
        {
            Words = new List<Word>();
            LoadData();
        }

        public void LoadData()
        {
            if (File.Exists(WordsFile))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(WordsFile, FileMode.Open))
                    {
                        Words = (List<Word>)formatter.Deserialize(fs);
                    }
                }
                catch
                {
                    CreateDefaultWords();
                }
            }
            else
            {
                CreateDefaultWords();
            }
        }

        private void CreateDefaultWords()
        {
            Words = new List<Word>
            {
                new Word("красивый", new List<string> { "прекрасный", "великолепный", "восхитительный", "привлекательный" }, "Прилагательные"),
                new Word("большой", new List<string> { "огромный", "громадный", "крупный", "гигантский" }, "Прилагательные"),
                new Word("быстрый", new List<string> { "скорый", "стремительный", "резвый", "молниеносный" }, "Прилагательные"),
                new Word("умный", new List<string> { "разумный", "мудрый", "толковый", "сообразительный" }, "Прилагательные"),
                new Word("грустный", new List<string> { "печальный", "унылый", "тоскливый", "скорбный" }, "Прилагательные"),
                new Word("идти", new List<string> { "шагать", "ступать", "двигаться", "направляться" }, "Глаголы"),
                new Word("говорить", new List<string> { "разговаривать", "беседовать", "рассказывать", "вещать" }, "Глаголы"),
                new Word("смотреть", new List<string> { "глядеть", "взирать", "наблюдать", "разглядывать" }, "Глаголы"),
                new Word("работа", new List<string> { "труд", "деятельность", "занятие", "служба" }, "Существительные"),
                new Word("друг", new List<string> { "товарищ", "приятель", "союзник", "компаньон" }, "Существительные"),
            };
            SaveData();
        }

        public void SaveData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(WordsFile, FileMode.Create))
            {
                formatter.Serialize(fs, Words);
            }
        }

        public Word GetRandomWord()
        {
            if (Words.Count == 0) return null;
            Random rand = new Random();
            return Words[rand.Next(Words.Count)];
        }

        public List<string> GetCategories()
        {
            return Words.Select(w => w.Category).Distinct().OrderBy(c => c).ToList();
        }

        public List<Word> GetWordsByCategory(string category)
        {
            return Words.Where(w => w.Category == category).ToList();
        }

        public bool AdminLogin(string password)
        {
            return password == AdminPassword;
        }

        public void AddWord(string term, List<string> synonyms, string category)
        {
            Words.Add(new Word(term, synonyms, category));
            SaveData();
        }

        public bool RemoveWord(string term)
        {
            var word = Words.FirstOrDefault(w => w.Term == term.ToLower());
            if (word != null)
            {
                Words.Remove(word);
                SaveData();
                return true;
            }
            return false;
        }
    }
}