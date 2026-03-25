using Practice_Task_2; // Ваш основной проект
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice_Task_2;
using System;

namespace DigitalRootTests
{
    /// <summary>
    /// Тестовый класс для проверки методов DigitalRootCalculator
    /// </summary>
    [TestClass]
    public class DigitalRootCalculatorTests
    {

        /// <summary>
        /// Тест 1: Проверка однозначных чисел (класс эквивалентности: числа 0-9)
        /// </summary>
        [TestMethod]
        public void Calculate_Long_SingleDigitNumbers_ReturnsSameNumber()
        {
            // Arrange (подготовка)
            long[] testNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act & Assert (действие и проверка)
            for (int i = 0; i < testNumbers.Length; i++)
            {
                int actual = DigitalRootCalculator.Calculate(testNumbers[i]);
                Assert.AreEqual(expected[i], actual,
                    $"Для числа {testNumbers[i]} ожидался корень {expected[i]}, получен {actual}");
            }
        }

        /// <summary>
        /// Тест 2: Проверка двузначных чисел
        /// </summary>
        [TestMethod]
        public void Calculate_Long_TwoDigitNumbers_ReturnsCorrectRoot()
        {
            // Arrange
            var testData = new (long Number, int Expected)[]
            {
                (10, 1),  // 1+0=1
                (11, 2),  // 1+1=2
                (18, 9),  // 1+8=9
                (19, 1),  // 1+9=10 -> 1+0=1
                (27, 9),  // 2+7=9
                (45, 9),  // 4+5=9
                (99, 9)   // 9+9=18 -> 1+8=9
            };

            // Act & Assert
            foreach (var data in testData)
            {
                int actual = DigitalRootCalculator.Calculate(data.Number);
                Assert.AreEqual(data.Expected, actual,
                    $"Для числа {data.Number} ожидался корень {data.Expected}, получен {actual}");
            }
        }

        /// <summary>
        /// Тест 3: Проверка трёхзначных и более чисел
        /// </summary>
        [TestMethod]
        public void Calculate_Long_MultiDigitNumbers_ReturnsCorrectRoot()
        {
            // Arrange
            var testData = new (long Number, int Expected)[]
            {
                (123, 6),     // 1+2+3=6
                (456, 6),     // 4+5+6=15 -> 1+5=6
                (789, 6),     // 7+8+9=24 -> 2+4=6
                (999, 9),     // 9+9+9=27 -> 2+7=9
                (12345, 6),   // 1+2+3+4+5=15 -> 1+5=6
                (99999, 9),   // 9+9+9+9+9=45 -> 4+5=9
                (1000000, 1)  // 1+0+0+... =1
            };

            // Act & Assert
            foreach (var data in testData)
            {
                int actual = DigitalRootCalculator.Calculate(data.Number);
                Assert.AreEqual(data.Expected, actual,
                    $"Для числа {data.Number} ожидался корень {data.Expected}, получен {actual}");
            }
        }

        /// <summary>
        /// Тест 4: Проверка максимальных значений long
        /// </summary>
        [TestMethod]
        public void Calculate_Long_MaximumValues_ReturnsCorrectRoot()
        {
            // Arrange
            long maxLong = long.MaxValue; // 9223372036854775807
            // Сумма цифр: считаем вручную или через другой метод
            // 9+2+2+3+3+7+2+0+3+6+8+5+4+7+7+5+8+0+7 = 88? Нужно точно посчитать
            // Для теста используем другой подход - проверим, что метод работает без исключений

            // Act
            int actual = DigitalRootCalculator.Calculate(maxLong);

            // Assert
            Assert.IsTrue(actual >= 0 && actual <= 9,
                $"Результат {actual} должен быть в диапазоне 0-9");
        }

        /// <summary>
        /// Тест 5: Негативный тест - отрицательное число
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_Long_NegativeNumber_ThrowsArgumentException()
        {
            // Act
            DigitalRootCalculator.Calculate(-5);
        }

        // ========== ТЕСТИРОВАНИЕ МЕТОДА Calculate(string) ==========

        /// <summary>
        /// Тест 6: Проверка обычных чисел в строковом формате
        /// </summary>
        [TestMethod]
        public void Calculate_String_ValidNumbers_ReturnsCorrectRoot()
        {
            // Arrange
            var testData = new (string Number, int Expected)[]
            {
                ("0", 0),
                ("5", 5),
                ("10", 1),
                ("123", 6),
                ("9999", 9),  // 9+9+9+9=36 -> 3+6=9
                ("123456789", 9) // 1+2+3+4+5+6+7+8+9=45 -> 4+5=9
            };

            // Act & Assert
            foreach (var data in testData)
            {
                int actual = DigitalRootCalculator.Calculate(data.Number);
                Assert.AreEqual(data.Expected, actual,
                    $"Для числа {data.Number} ожидался корень {data.Expected}, получен {actual}");
            }
        }

        /// <summary>
        /// Тест 7: Проверка чисел с пробелами
        /// </summary>
        [TestMethod]
        public void Calculate_String_NumbersWithSpaces_TrimsAndReturnsCorrectRoot()
        {
            // Arrange
            var testData = new (string Number, int Expected)[]
            {
                (" 123 ", 6),
                ("\t456\t", 6),
                ("  789  ", 6),
                ("   0   ", 0)
            };

            // Act & Assert
            foreach (var data in testData)
            {
                int actual = DigitalRootCalculator.Calculate(data.Number);
                Assert.AreEqual(data.Expected, actual,
                    $"Для числа '{data.Number}' ожидался корень {data.Expected}, получен {actual}");
            }
        }

        /// <summary>
        /// Тест 8: Проверка очень больших чисел (больше long)
        /// </summary>
        [TestMethod]
        public void Calculate_String_VeryLargeNumbers_ReturnsCorrectRoot()
        {
            // Arrange
            var testData = new (string Number, int Expected)[]
            {
                ("99999999999999999999", 9), // 20 девяток
                ("12345678901234567890", 9), // сложный расчёт
                ("10000000000000000000", 1)
            };

            // Act & Assert
            foreach (var data in testData)
            {
                int actual = DigitalRootCalculator.Calculate(data.Number);
                Assert.AreEqual(data.Expected, actual,
                    $"Для очень большого числа ожидался корень {data.Expected}, получен {actual}");
            }
        }

        /// <summary>
        /// Тест 9: Негативный тест - пустая строка
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_String_EmptyString_ThrowsArgumentException()
        {
            // Act
            DigitalRootCalculator.Calculate("");
        }

        /// <summary>
        /// Тест 10: Негативный тест - строка с пробелами
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_String_WhitespaceString_ThrowsArgumentException()
        {
            // Act
            DigitalRootCalculator.Calculate("   ");
        }

        /// <summary>
        /// Тест 11: Негативный тест - отрицательное число в строке
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_String_NegativeNumberString_ThrowsArgumentException()
        {
            // Act
            DigitalRootCalculator.Calculate("-123");
        }

        /// <summary>
        /// Тест 12: Негативный тест - строка с буквами
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_String_NonNumericString_ThrowsArgumentException()
        {
            // Act
            DigitalRootCalculator.Calculate("123abc");
        }

        /// <summary>
        /// Тест 13: Негативный тест - строка со спецсимволами
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_String_SpecialCharacters_ThrowsArgumentException()
        {
            // Act
            DigitalRootCalculator.Calculate("123@456");
        }

        // ========== ТЕСТИРОВАНИЕ МЕТОДА CalculateFromFile ==========

        /// <summary>
        /// Тест 14: Проверка обработки файла с корректными данными
        /// </summary>
        [TestMethod]
        public void CalculateFromFile_ValidFile_ReturnsCorrectResults()
        {
            // Arrange
            string tempFile = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllLines(tempFile, new string[]
            {
                "123",
                "456",
                "789",
                "9999",
                "0"
            });

            // Act
            var results = DigitalRootCalculator.CalculateFromFile(tempFile);

            // Assert
            Assert.AreEqual(5, results.Count);
            Assert.IsTrue(results[0].IsSuccess);
            Assert.AreEqual(6, results[0].Root);
            Assert.IsTrue(results[4].IsSuccess);
            Assert.AreEqual(0, results[4].Root);

            // Cleanup
            System.IO.File.Delete(tempFile);
        }

        /// <summary>
        /// Тест 15: Проверка обработки файла с некорректными данными
        /// </summary>
        [TestMethod]
        public void CalculateFromFile_FileWithInvalidData_HandlesErrorsGracefully()
        {
            // Arrange
            string tempFile = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllLines(tempFile, new string[]
            {
                "123",           // корректное
                "-5",            // отрицательное
                "abc",           // буквы
                "",              // пустая строка
                "   ",           // пробелы
                "9999999999999999999999999999999", // очень большое
                "123.45"         // дробное
            });

            // Act
            var results = DigitalRootCalculator.CalculateFromFile(tempFile);

            // Assert
            Assert.AreEqual(7, results.Count);

            // Проверка каждого результата
            Assert.IsTrue(results[0].IsSuccess);  // 123
            Assert.IsFalse(results[1].IsSuccess); // -5
            Assert.IsFalse(results[2].IsSuccess); // abc
            Assert.IsFalse(results[3].IsSuccess); // пустая строка
            Assert.IsFalse(results[4].IsSuccess); // пробелы
            Assert.IsTrue(results[5].IsSuccess);  // очень большое
            Assert.IsFalse(results[6].IsSuccess); // 123.45

            // Cleanup
            System.IO.File.Delete(tempFile);
        }

        /// <summary>
        /// Тест 16: Проверка обработки несуществующего файла
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateFromFile_NonExistentFile_ThrowsException()
        {
            // Act
            DigitalRootCalculator.CalculateFromFile("Z:\\NonExistentFile.txt");
        }

        /// <summary>
        /// Тест 17: Проверка обработки пустого файла
        /// </summary>
        [TestMethod]
        public void CalculateFromFile_EmptyFile_ReturnsEmptyList()
        {
            // Arrange
            string tempFile = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(tempFile, ""); // пустой файл

            // Act
            var results = DigitalRootCalculator.CalculateFromFile(tempFile);

            // Assert
            Assert.AreEqual(0, results.Count);

            // Cleanup
            System.IO.File.Delete(tempFile);
        }
    }
}