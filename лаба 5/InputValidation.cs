using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   

    namespace лаба_5
    {
        static class InputValidation
        {
            public static double GetPositiveNumber(string prompt)
            {
                double number = 0;
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out number) && number > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное число.");
                    }
                }
                return number;
            }

            public static int GetMenuChoice()
            {
                int menuChoice = 0;
                bool validMenuChoice = false;

                while (!validMenuChoice)
                {
                    if (int.TryParse(Console.ReadLine(), out menuChoice) && menuChoice >= 1 && menuChoice <= 5)
                    {
                        validMenuChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода. Пожалуйста, введите число от 1 до 5.");
                    }
                }
                return menuChoice;
            }
        }
    }

    

