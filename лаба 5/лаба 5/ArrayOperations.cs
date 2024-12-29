using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5
{
    using System;

    namespace лаба_5
    {
        class ArrayOperations
        {
            private int[] array;
            private int length;

            // Конструктор без параметров (по умолчанию 10 элементов)
            public ArrayOperations()
            {
                length = 10; // По умолчанию 10 элементов
                array = CreateArray(length);
            }

            // Конструктор с параметрами
            public ArrayOperations(int length)
            {
                try
                {
                    if (length <= 0 || length > 10)
                    {
                        throw new ArgumentOutOfRangeException("Длина массива должна быть от 1 до 10.");
                    }
                    this.length = length;
                    array = CreateArray(length);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    // Можно задать значение по умолчанию или завершить выполнение
                    Console.WriteLine("Будет выполен массив с длиной по умолчанияю!");
                    this.length = 10; // Например, задаем значение по умолчанию
                    array = CreateArray(this.length);
                }
            }

            // Метод для создания массива
            private int[] CreateArray(int length)
            {
                int[] array = new int[length];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(10); // Генерируем случайные числа от 0 до 9
                }
                return array;
            }
            public void PrintArray(int[] array)
            {
                Console.WriteLine(string.Join(", ", array));
            }

            // Метод для печати массива
            public void PrintArray()
            {
                Console.WriteLine(string.Join(", ", array));
            }

            // Метод для сортировки массива и измерения времени
            public void SortAndTime()
            {
                Time(array);
            }

            private void Time(int[] array)
            {
                // Сортировка вставкой
                int[] insertionArray = CopyArray(array);
                var insertionWatch = System.Diagnostics.Stopwatch.StartNew();
                InsertionSort(insertionArray);
                insertionWatch.Stop();
                Console.WriteLine("Отсортированный массив вставкой:");
                Console.WriteLine($"Время сортировки вставкой: {insertionWatch.Elapsed.TotalMilliseconds} мс");
                PrintArray(insertionArray);
            }

            private int[] CopyArray(int[] arr)
            {
                int[] copy = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    copy[i] = arr[i]; // Копируем каждый элемент по индексу
                }
                return copy;
            }

            private void InsertionSort(int[] insertionArray)
            {
                for (int i = 1; i < insertionArray.Length; i++)
                {
                    int key = insertionArray[i];
                    int j = i - 1;

                    while (j >= 0 && insertionArray[j] > key)
                    {
                        insertionArray[j + 1] = insertionArray[j];
                        j--;
                    }
                    insertionArray[j + 1] = key;
                }
            }
        }
    }

    
}
