using System;
using лаба_5.лаба_5;

namespace лаба_5
{
    static class GuessingGame
    {
        public static void PlayGuessingGame()
        {
            double a = InputValidation.GetPositiveNumber("Введите число a (положительное): ");
            double b = InputValidation.GetPositiveNumber("Введите число b (положительное): ");

            if (Math.Cos(2 * a) >= 0)
            {
                double result = CalculateResult(a, b);
                Console.WriteLine($"Вычисленный результат: {result:F2}");
                Attempts(result);
            }
            else
            {
                Console.WriteLine("Условие для вычисления не выполнено. Попробуйте другие значения a и b.");
            }
        }

        private static double CalculateResult(double a, double b)
        {
            return Math.Sin(Math.Log(b, 5)) / Math.Sqrt(Math.Cos(2 * a));
        }

        private static void Attempts(double correctAnswer)
        {
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Введите ваш ответ: ");
                double userAnswer;

                while (!double.TryParse(Console.ReadLine(), out userAnswer))
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
                }

                if (Math.Round(userAnswer, 2) == Math.Round(correctAnswer, 2))
                {
                    Console.WriteLine("Ответ верный! Вы выиграли!");
                    return;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Ответ неверный. У вас осталось {attempts} попыток.");
                }
            }
        }
    }
}

