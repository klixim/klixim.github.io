using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice_Task_2
{
    /// <summary>
    /// Класс для вычисления цифрового корня числа
    /// </summary>
    public static class DigitalRootCalculator
    {
        /// <summary>
        /// Вычисляет цифровой корень натурального числа
        /// </summary>
        public static int Calculate(long number)
        {
            if (number < 0)
                throw new ArgumentException("Число должно быть натуральным (неотрицательным)");

            if (number == 0)
                return 0;

            while (number >= 10)
            {
                number = SumOfDigits(number);
            }
            return (int)number;
        }

        /// <summary>
        /// Вычисляет цифровой корень числа, заданного строкой
        /// </summary>
        public static int Calculate(string numberStr)
        {
            if (string.IsNullOrWhiteSpace(numberStr))
                throw new ArgumentException("Строка не может быть пустой");

            numberStr = numberStr.Trim();

            if (numberStr.StartsWith("-"))
                throw new ArgumentException("Число должно быть натуральным (неотрицательным)");

            if (!numberStr.All(char.IsDigit))
                throw new ArgumentException("Строка должна содержать только цифры");

            if (long.TryParse(numberStr, out long num) && num >= 0)
                return Calculate(num);

            // Для очень больших чисел
            string current = numberStr;
            while (current.Length > 1)
            {
                long sum = 0;
                foreach (char c in current)
                {
                    sum += c - '0';
                }
                current = sum.ToString();
            }
            return int.Parse(current);
        }

        /// <summary>
        /// Вычисляет сумму цифр числа
        /// </summary>
        private static long SumOfDigits(long n)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Класс для хранения результата обработки числа из файла
        /// </summary>
        public class FileProcessResult
        {
            public string Number { get; set; }
            public int? Root { get; set; }
            public string Error { get; set; }
            public bool IsSuccess => Root.HasValue;
        }

        /// <summary>
        /// Вычисляет цифровые корни для всех чисел из файла
        /// </summary>
        public static List<FileProcessResult> CalculateFromFile(string filePath)
        {
            var results = new List<FileProcessResult>();

            try
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var result = new FileProcessResult();

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        result.Number = "(пустая строка)";
                        result.Error = "Строка пуста";
                        results.Add(result);
                        continue;
                    }

                    string trimmed = line.Trim();
                    result.Number = trimmed;

                    try
                    {
                        int root = Calculate(trimmed);
                        result.Root = root;
                    }
                    catch (ArgumentException ex)
                    {
                        result.Error = ex.Message;
                    }

                    results.Add(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения файла: {ex.Message}");
            }

            return results;
        }
    }
}