using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DictionaryLibrary
{
    public class Slovar
    {
        private List<string> list = new List<string>();
        private string filename;
        private int count;

        public Slovar(string filename)
        {
            this.filename = filename;
            OpenFile();
            count = list.Count;
        }

        public int Count => count;

        private void OpenFile()
        {
            try
            {
                list.Clear();
                using (StreamReader f = new StreamReader(filename, Encoding.UTF8))
                {
                    while (!f.EndOfStream)
                    {
                        string word = f.ReadLine()?.Trim();
                        if (!string.IsNullOrEmpty(word) && !list.Contains(word))
                            list.Add(word);
                    }
                }
            }
            catch
            {
                throw new Exception("Ошибка доступа к файлу!");
            }
        }

        public List<string> GetAllWords() => new List<string>(list);

        public bool AddWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return false;
            if (list.Contains(word)) return false;
            list.Add(word);
            count = list.Count;
            return true;
        }

        public bool RemoveWord(string word)
        {
            if (list.Remove(word))
            {
                count = list.Count;
                return true;
            }
            return false;
        }

        public void SaveToFile(string path)
        {
            File.WriteAllLines(path, list, Encoding.UTF8);
        }

        // Нечёткий поиск (расстояние Левенштейна <= 3)
        public List<string> FuzzySearch(string pattern, int maxDistance = 3)
        {
            if (string.IsNullOrEmpty(pattern)) return new List<string>();
            return list.Where(word => LevenshteinDistance(word, pattern) <= maxDistance).ToList();
        }

        private int LevenshteinDistance(string s, string t)
        {
            int n = s.Length, m = t.Length;
            int[,] d = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++) d[i, 0] = i;
            for (int j = 0; j <= m; j++) d[0, j] = j;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    int cost = (s[i - 1] == t[j - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            return d[n, m];
        }

        // Вариант 13: слова, начинающиеся или заканчивающиеся на заданное количество согласных
        public List<string> SearchByConsonantsAtStartOrEnd(int consonantCount, bool atStart)
        {
            if (consonantCount <= 0) return new List<string>();

            var vowels = new HashSet<char>("аеёиоуыэюяaeiouy");
            return list.Where(word =>
            {
                if (string.IsNullOrEmpty(word)) return false;
                word = word.ToLower();
                if (atStart)
                {
                    if (word.Length < consonantCount) return false;
                    return word.Take(consonantCount).All(ch => !vowels.Contains(ch));
                }
                else
                {
                    if (word.Length < consonantCount) return false;
                    return word.Skip(word.Length - consonantCount).All(ch => !vowels.Contains(ch));
                }
            }).ToList();
        }
    }
}