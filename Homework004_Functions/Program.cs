// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


// Console.WriteLine("Введите целые числа. Для завершения введите 'q' или число с чётной суммой цифр.");

// while (true) 
// {
//   Console.Write("Введите число: ");
//   string input = Console.ReadLine();

//   if (input.ToLower() == "q")
//   {
//      Console.WriteLine("Программа завершена.");
//      break;
//   }

//   if (IsEvenDigitSum(int.Parse(input)))
//   {
//       Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
//       break;
//   }
// }
    

// static bool IsEvenDigitSum(int number)
// {
//   int sum = 0;
//   foreach (char digitChar in number.ToString())
//   {
//     sum += int.Parse(digitChar.ToString());
//   }

//   return sum % 2 == 0;
// }


// // ---------------------------------------------------------

// // Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[10]; // Массив для хранения случайных чисел
//         Random random = new Random(); // Генератор случайных чисел
//         int evenCount = 0; // Счетчик четных чисел

//         // Заполнение массива случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
//             Console.Write(numbers[i] + " "); // Вывод сгенерированного числа с пробелом
          
//             // Проверка на четность и увеличение счетчика
//             if (numbers[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         // Вывод количества четных чисел в массиве
//         Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
//     }
// }


// // -----------------------------------------------------------

// // Задача 3: Напишите программу, которая перевернёт одномерный массив 
// // (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        int[] numbers = {1, 2, 3, 5, 6, 7, 8, 9}; // Исходный массив

        // Вывод исходного массива
        Console.Write("Исходный массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Реверсирование массива с использованием Array.Reverse
        Array.Reverse(numbers);

        // Вывод измененного массива
        Console.Write("\nПеревернутый массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}


