// // Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// // Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создание массива из 10 целых чисел от 1 до 100
//         int[] array = { 15, 25, 30, 40, 50, 60, 70, 80, 90, 100 };

//         // Нахождение количества элементов в отрезке [20, 90]
//         int count = CountElementsInRange(array, 20, 90);

//         Console.WriteLine($"Количество элементов в отрезке [20, 90]: {count}");
//     }

//     static int CountElementsInRange(int[] array, int lowerBound, int upperBound)
//     {
//         int count = 0;

//         foreach (int element in array)
//         {
//             if (element >= lowerBound && element <= upperBound)
//             {
//                 count++;
//             }
//         }

//         return count;
//     }
// }


// // _______________________________________________________________________________

// // Задача 2: Задайте массив на 10 целых чисел. 
// // Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] arr = { 15, 25, 31, 140, 52, 60, 71, 80, 91, 100 };
        
// int evenCount = 0;
// int index = 0;

// while (index < arr.Length)
// {
//     if (arr[index] % 2 == 0)
//     {
//         evenCount++;
//     }

//     index++;
// }

// Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");


// // ______________________________________________________________________

// // Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// double[] arr = { 15.5, 25.3, 30.8, 40.2, 50.1, 60.7, 71.8, 80.6, 91.5, 100.0 };
        
// double min = arr[0];
// double max = arr[0];

// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }

//      if (arr[i] > max)
//         {
//            max = arr[i];
//         } 
// }

// double diff = max - min;

// Console.WriteLine($"Разница между max и min элементами массива: {diff}");

// //________________________________________________________

// // Задача 3: Задайте массив из случайных, вещественных чисел с ненулевой дробной частью. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// int arrSize = 10;

// double[] arr = new double[arrSize];

// Random random = new Random();

// for (int i = 0; i < arrSize; i++)
// {
//     arr[i] = random.NextDouble() * 10.0;

//     Console.Write($"{arr[i]:F1} ");
// }

// Console.WriteLine();

// double min = arr[0];
// double max = arr[0];

// for (int i = 1; i < arrSize; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }

//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }

// double diff = max - min;

// Console.WriteLine($"Разница между max и min элементами массива: {diff:F1}");



// //_________________________________________________________

// // Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// // Создайте массив, состоящий из цифр этого числа. 
// // Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// // Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите натуральное число в диапазоне от 1 до 100000:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        
        int[] digitArray = GetDigitArray(inputNumber);

        // Выводим массив на консоль
        Console.WriteLine("Массив из цифр числа:");

        foreach (int digit in digitArray)
        {
            Console.Write(digit + " ");
        }
    

    static int[] GetDigitArray(int number)
    {
        // Определяем количество цифр в числе
        int count = 0;
        int tempNumber = number;

        while (tempNumber > 0)
        {
            tempNumber /= 10;
            count++;
        }

        // Создаем массив из цифр числа
        int[] digitArray = new int[count];
        tempNumber = number;

        for (int i = count - 1; i >= 0; i--)
        {
            digitArray[i] = tempNumber % 10;
            tempNumber /= 10;
        }

        return digitArray;    
    }   

 



