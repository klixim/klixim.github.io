using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeTask8
{
    [Serializable]
    public class Word
    {
        public string Term { get; set; }
        public List<string> Synonyms { get; set; }
        public string Category { get; set; }

        public Word()
        {
            Synonyms = new List<string>();
            Category = "Общая";
        }

        public Word(string term, List<string> synonyms, string category = "Общая")
        {
            Term = term.ToLower().Trim();
            Synonyms = synonyms.Select(s => s.ToLower().Trim()).ToList();
            Category = category;
        }

        public bool CheckSynonym(string userAnswer)
        {
            return Synonyms.Contains(userAnswer.ToLower().Trim());
        }

        public string GetSynonymsDisplay()
        {
            return string.Join(", ", Synonyms);
        }

        public void Update(string newTerm, List<string> newSynonyms, string newCategory)
        {
            Term = newTerm.ToLower().Trim();
            Synonyms = newSynonyms.Select(s => s.ToLower().Trim()).ToList();
            Category = newCategory;
        }
    }
}