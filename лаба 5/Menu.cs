using System;
using лаба_5.лаба_5;

namespace лаба_5
{
    class Menu
    {
        private string _studentName;
        private string _group;
        private Game _game;
        private ArrayOperations _arrayOperations;


        public Menu(string studentName, string group)
        {
            _studentName = studentName;
            _group = group;
            _game = new Game();
        }

        public void Start()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                exitProgram = ShowMenu();
            }
        }

        private bool ShowMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Отгадай ответ");
            Console.WriteLine("2. Об авторе");
            Console.WriteLine("3. Выход");
            Console.WriteLine("4. Создай свой массив!!!");
            Console.WriteLine("5. Сыграем в крестики нолики???");
            Console.Write("Выберите пункт меню (1-5): ");

            int menuChoice = InputValidation.GetMenuChoice();

            switch (menuChoice)
            {
                case 1:
                    GuessingGame.PlayGuessingGame();
                    break;
                case 2:
                    ShowAuthorInfo();
                    break;
                case 3:
                    return ConfirmExit();
                case 4:
                    CreateAndSortArray();
                    break;
                case 5:
                    _game.TicTacToe();
                    break;
            }
            return false;
        }

        private void CreateAndSortArray()
        {
            Console.WriteLine("Введите длину массива (от 1 до 10):");
            int length = int.Parse(Console.ReadLine());
            ArrayOperations customArray = new ArrayOperations(length);
            Console.WriteLine("Пользовательский массив:");
            customArray.PrintArray();
            customArray.SortAndTime();
        }

        private void ShowAuthorInfo()
        {
            Console.WriteLine($"ФИО студента: {_studentName}, Группа: {_group}");
        }

        private bool ConfirmExit()
        {
            bool exitConfirmed = false;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine("Вы уверены, что хотите выйти? (д/н): ");
                string confirmation = Console.ReadLine();
                valid = confirmation.ToLower() == "д" || confirmation.ToLower() == "н";

                if (valid)
                {
                    exitConfirmed = confirmation.ToLower() == "д";
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите 'д' или 'н'.");
                }
            }
            return exitConfirmed;
        }
    }
}

