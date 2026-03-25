using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice_Task_4
{
    public class StudentGroup
    {
        public string GroupNumber { get; set; }
        public int FiveCount { get; set; }
        public int FourCount { get; set; }
        public int ThreeCount { get; set; }
        public int TwoCount { get; set; }
        public int NotAttestedCount { get; set; }

        public double AverageScore
        {
            get
            {
                int total = FiveCount + FourCount + ThreeCount + TwoCount + NotAttestedCount;
                if (total == 0) return 0;
                int sum = FiveCount * 5 + FourCount * 4 + ThreeCount * 3 + TwoCount * 2 + NotAttestedCount * 0;
                return (double)sum / total;
            }
        }
    }

    public class GroupCollection
    {
        private List<StudentGroup> groups = new List<StudentGroup>();
        public string DisciplineName { get; set; } = "Не выбрано";

        public List<StudentGroup> Groups => groups;

        public void AddGroup(StudentGroup group)
        {
            groups.Add(group);
        }

        public void Clear()
        {
            groups.Clear();
        }

        public int Count => groups.Count;

        public StudentGroup this[int index] => groups[index];

        public StudentGroup GetBestGroup()
        {
            if (groups.Count == 0) return null;
            return groups.OrderByDescending(g => g.AverageScore).FirstOrDefault();
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(DisciplineName);
                sw.WriteLine(groups.Count);
                foreach (var g in groups)
                {
                    sw.WriteLine($"{g.GroupNumber} {g.FiveCount} {g.FourCount} {g.ThreeCount} {g.TwoCount} {g.NotAttestedCount}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename)) return;
            using (StreamReader sr = new StreamReader(filename))
            {
                DisciplineName = sr.ReadLine();
                int count = int.Parse(sr.ReadLine());
                groups.Clear();
                for (int i = 0; i < count; i++)
                {
                    string[] parts = sr.ReadLine().Split(' ');
                    groups.Add(new StudentGroup
                    {
                        GroupNumber = parts[0],
                        FiveCount = int.Parse(parts[1]),
                        FourCount = int.Parse(parts[2]),
                        ThreeCount = int.Parse(parts[3]),
                        TwoCount = int.Parse(parts[4]),
                        NotAttestedCount = int.Parse(parts[5])
                    });
                }
            }
        }
    }
}