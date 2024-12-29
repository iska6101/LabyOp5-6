using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5
{
    


        internal class Game
        {
            private const int SIZE = 10;
            private const string EMPTY_CELL = " ";
            private const string PLAYER_X = "X";
            private const string PLAYER_O = "O";

            public void TicTacToe()
            {
                string[,] board = new string[SIZE, SIZE];
                string currentPlayer = PLAYER_X;
                bool gameActive = true;

                while (gameActive)
                {
                    PrintBoard(board);
                    Console.WriteLine($"Игрок {currentPlayer}, выберите строку и столбец (0-{SIZE - 1}):");

                    int row, col;
                    bool validInput = false;

                    while (!validInput)
                    {
                        Console.Write("Введите строку: ");
                        if (int.TryParse(Console.ReadLine(), out row) && row >= 0 && row < SIZE)
                        {
                            Console.Write("Введите столбец: ");
                            if (int.TryParse(Console.ReadLine(), out col) && col >= 0 && col < SIZE)
                            {
                                if (string.IsNullOrEmpty(board[row, col]) || board[row, col] == EMPTY_CELL)
                                {
                                    board[row, col] = currentPlayer;
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Эта клетка уже занята. Попробуйте снова.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Неверный ввод. Пожалуйста, введите число от 0 до {SIZE - 1} для столбца.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Неверный ввод. Пожалуйста, введите число от 0 до {SIZE - 1} для строки.");
                        }
                    }

                    if (CheckWinner(board, currentPlayer))
                    {
                        PrintBoard(board);
                        Console.WriteLine($"Игрок {currentPlayer} выиграл!");
                        gameActive = false;
                    }
                    else if (IsBoardFull(board))
                    {
                        PrintBoard(board);
                        Console.WriteLine("Ничья!");
                        gameActive = false;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == PLAYER_X) ? PLAYER_O : PLAYER_X;
                    }
                }
            }

            private void PrintBoard(string[,] board)
            {
                Console.WriteLine("Текущая доска:");
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        Console.Write(board[i, j] ?? EMPTY_CELL);
                        if (j < board.GetLength(1) - 1) Console.Write("|");
                    }
                    Console.WriteLine();
                    if (i < board.GetLength(0) - 1) Console.WriteLine(new string('-', board.GetLength(1) * 2 - 1));
                }
            }

            private bool CheckWinner(string[,] board, string player)
            {
                // Проверка горизонтальных и вертикальных линий
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j <= board.GetLength(1) - 5; j++)
                    {
                        if (board[i, j] == player && board[i, j + 1] == player && board[i, j + 2] == player && board[i, j + 3] == player && board[i, j + 4] == player)
                            return true;

                        if (board[j, i] == player && board[j + 1, i] == player && board[j + 2, i] == player && board[j + 3, i] == player && board[j + 4, i] == player)
                            return true;
                    }
                }

                // Проверка диагоналей
                for (int i = 0; i <= board.GetLength(0) - 5; i++)
                {
                    for (int j = 0; j <= board.GetLength(1) - 5; j++)
                    {
                        if (board[i, j] == player && board[i + 1, j + 1] == player && board[i + 2, j + 2] == player && board[i + 3, j + 3] == player && board[i + 4, j + 4] == player)
                            return true;

                        if (board[i, j + 4] == player && board[i + 1, j + 3] == player && board[i + 2, j + 2] == player && board[i + 3, j + 1] == player && board[i + 4, j] == player)
                            return true;
                    }
                }

                return false;
            }

            private bool IsBoardFull(string[,] board)
            {
                foreach (var cell in board)
                {
                    if (string.IsNullOrEmpty(cell) || cell == EMPTY_CELL)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    
}
    
    

