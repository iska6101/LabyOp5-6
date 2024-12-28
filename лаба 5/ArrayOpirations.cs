using System;
using System.Linq.Expressions;

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
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\nБудет выводен массив по умолчанию");
                this.length = 10;
                array=CreateArray(this.length);
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

        // Метод для печати массива
        public void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
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

