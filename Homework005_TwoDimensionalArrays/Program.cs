// // Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем двумерный массив (для примера 3x3)
//         int[,] array = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());

//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         // Проверяем, существует ли указанный элемент в массиве
//         if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
//         {
//             // Выводим значение элемента
//             Console.WriteLine($"Значение элемента: {array[row, column]}");
//         }
//         else
//         {
//             // Сообщаем, что такого элемента нет
//             Console.WriteLine("Такого элемента не существует");
//         }
//     }
// }


// // ---------------------------------------------------

// // Задача 2: Задайте двумерный массив. Напишите программу, 
// // которая поменяет местами первую и последнюю строку массива.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем двумерный массив
//         int[,] array = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         // Выводим исходный массив
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Меняем местами первую и последнюю строки
//         SwapRows(array, 0, array.GetLength(0) - 1);

//         // Выводим измененный массив
//         Console.WriteLine("\nМассив после замены строк:");
//         PrintArray(array);
//     }

//     // Метод для вывода массива на консоль
//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Метод для замены местами двух строк в массиве
//     static void SwapRows(int[,] array, int row1, int row2)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
// }


// // -----------------------------------------

// // Задача 3: Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем прямоугольный двумерный массив
//         int[,] array = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9},
//             {10, 11, 12}
//         };

//         // Выводим исходный массив
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Находим строку с наименьшей суммой элементов
//         int minRow = FindMinSumRow(array);

//         // Выводим информацию о строке с наименьшей суммой
//         Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}");
//     }

//     // Метод для вывода массива на консоль
//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Метод для нахождения строки с наименьшей суммой элементов
//     static int FindMinSumRow(int[,] array)
//     {
//         int minSum = int.MaxValue;
//         int minRow = 0;

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int currentSum = 0;

//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 currentSum += array[i, j];
//             }

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minRow = i;
//             }
//         }

//         return minRow;
//     }
// }


// // ------------------------------------------------

// // Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// // Напишите программу, которая удалит строку и столбец, 
// // на пересечении которых расположен наименьший элемент массива. 
// // Под удалением понимается создание нового двумерного массива без строки и столбца

using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив
        int[,] array = {
            {5, 2, 3},
            {4, 1, 6},
            {7, 8, 9}
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим индексы минимального элемента
        int minRow, minCol;
        FindMinElementIndex(array, out minRow, out minCol);

        // Удаляем строку и столбец с минимальным элементом
        int[,] newArray = RemoveRowAndColumn(array, minRow, minCol);

        // Выводим измененный массив
        Console.WriteLine("\nМассив после удаления строки и столбца с минимальным элементом:");
        PrintArray(newArray);
    }

    // Метод для вывода массива на консоль
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для нахождения индексов минимального элемента
    static void FindMinElementIndex(int[,] array, out int minRow, out int minCol)
    {
        minRow = 0;
        minCol = 0;
        int minElement = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }
    }

    // Метод для удаления строки и столбца по указанным индексам
    static int[,] RemoveRowAndColumn(int[,] array, int rowToRemove, int colToRemove)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создаем новый массив с уменьшенными размерами
        int[,] newArray = new int[rows - 1, cols - 1];

        // Копируем элементы из исходного массива в новый, исключая строку и столбец
        for (int i = 0, newRow = 0; i < rows; i++)
        {
            if (i == rowToRemove)
            {
                continue; // Пропускаем удаляемую строку
            }

            for (int j = 0, newCol = 0; j < cols; j++)
            {
                if (j != colToRemove)
                {
                    newArray[newRow, newCol] = array[i, j];
                    newCol++;
                }
            }

            newRow++;
        }

        return newArray;
    }
}