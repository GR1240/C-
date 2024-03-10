/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам.

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string[] inputArray = Console.ReadLine().Split(',');

        // Формирование нового массива из строк, длина которых меньше или равна 3 символам
        string[] resultArray = FilterStrings(inputArray);

        // Вывод вводных элементов массива
        // Console.WriteLine($"Входной массив: [{string.Join(", ", inputArray)}]");
        
        // Вывод нового массива в нужном формате
        Console.WriteLine($"Результат: [{string.Join(", ", resultArray)}]");
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Заполнение нового массива с учетом длины
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}

