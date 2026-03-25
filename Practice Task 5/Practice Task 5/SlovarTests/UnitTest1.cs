using System;
using System.Collections.Generic;

namespace UnitTest1
{
    public class TestRunner
    {
        private int passedTests = 0;
        private int failedTests = 0;
        private List<string> errors = new List<string>();

        public void RunTest(Action testMethod, string testName)
        {
            try
            {
                testMethod();
                passedTests++;
                Console.WriteLine($"[PASS] {testName}");
            }
            catch (Exception ex)
            {
                failedTests++;
                string error = $"[FAIL] {testName}: {ex.Message}";
                errors.Add(error);
                Console.WriteLine(error);
                Console.WriteLine($"      {ex.StackTrace}");
            }
        }

        public void PrintSummary()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine($"РЕЗУЛЬТАТЫ ТЕСТИРОВАНИЯ:");
            Console.WriteLine($"Пройдено: {passedTests}");
            Console.WriteLine($"Не пройдено: {failedTests}");
            Console.WriteLine($"Всего: {passedTests + failedTests}");

            if (errors.Count > 0)
            {
                Console.WriteLine("\nОШИБКИ:");
                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
            }
            Console.WriteLine(new string('=', 50));
        }
    }

    public static class Assert
    {
        public static void IsTrue(bool condition, string message = "")
        {
            if (!condition)
            {
                throw new Exception($"Assert.IsTrue failed: {message}");
            }
        }

        public static void IsFalse(bool condition, string message = "")
        {
            if (condition)
            {
                throw new Exception($"Assert.IsFalse failed: {message}");
            }
        }

        public static void AreEqual<T>(T expected, T actual, string message = "")
        {
            if (!Equals(expected, actual))
            {
                throw new Exception($"Assert.AreEqual failed: Expected '{expected}', Actual '{actual}'. {message}");
            }
        }

        public static void AreNotEqual<T>(T expected, T actual, string message = "")
        {
            if (Equals(expected, actual))
            {
                throw new Exception($"Assert.AreNotEqual failed: Values are equal '{expected}'. {message}");
            }
        }

        public static void IsNull(object obj, string message = "")
        {
            if (obj != null)
            {
                throw new Exception($"Assert.IsNull failed: Object is not null. {message}");
            }
        }

        public static void IsNotNull(object obj, string message = "")
        {
            if (obj == null)
            {
                throw new Exception($"Assert.IsNotNull failed: Object is null. {message}");
            }
        }

        public static void Contains(string expected, System.Collections.IList collection, string message = "")
        {
            if (collection == null || !collection.Contains(expected))
            {
                throw new Exception($"Assert.Contains failed: Collection does not contain '{expected}'. {message}");
            }
        }

        public static void DoesNotContain(string expected, System.Collections.IList collection, string message = "")
        {
            if (collection != null && collection.Contains(expected))
            {
                throw new Exception($"Assert.DoesNotContain failed: Collection contains '{expected}'. {message}");
            }
        }
    }
}