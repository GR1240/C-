// // Задача 1: Задайте двумерный массив символов (тип char [,]). 
// // Создать строку из символов этого массива.


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем двумерный массив символов
//         char[,] charArray = {
//             { 'H', 'e', 'l', 'l', 'o' },
//             { 'W', 'o', 'r', 'l', 'd' }
//         };

//         // Создаем строку из символов массива
//         string resultString = GetStringFromCharArray(charArray);

//         // Выводим результат
//         Console.WriteLine(resultString);
//     }

//     static string GetStringFromCharArray(char[,] charArray)
//     {
//         int rows = charArray.GetLength(0);
//         int columns = charArray.GetLength(1);

//         // Используем StringBuilder для эффективной конкатенации символов
//         System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 // Добавляем символ в StringBuilder
//                 stringBuilder.Append(charArray[i, j]);
//             }
//         }

//         // Преобразуем StringBuilder в строку и возвращаем
//         return stringBuilder.ToString();
//     }
// }


// // -------------------------------------------------------------------

// // Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// // Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем исходную строку с латинскими буквами в обоих регистрах
//         string inputString = "HeLLoWorLD";

//         // Формируем строку, в которой все заглавные буквы заменены на строчные
//         string resultString = ConvertToUpperToLower(inputString);

//         // Выводим результат
//         Console.WriteLine(resultString);
//     }

//     static string ConvertToUpperToLower(string input)
//     {
//         // Используем LINQ для замены каждой заглавной буквы на строчную
//         string result = new string(input.Select(c => char.IsUpper(c) ? char.ToLower(c) : c).ToArray());

//         return result;
//     }
// }


// // --------------------------------------------------

// // Задача 3: Задайте произвольную строку. 
// // Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем произвольную строку
//         string inputString = "A man, a plan, a canal, Panama";

//         // Проверяем, является ли строка палиндромом
//         bool isPalindrome = IsPalindrome(inputString);

//         // Выводим результат
//         if (isPalindrome)
//             Console.WriteLine("Строка является палиндромом.");
//         else
//             Console.WriteLine("Строка не является палиндромом.");
//     }

//     static bool IsPalindrome(string input)
//     {
//         // Приводим строку к нижнему регистру и удаляем не-буквенные символы
//         string cleanedString = new string(input.ToLower().ToCharArray()
//                                     .Where(c => Char.IsLetter(c)).ToArray());

//         // Переворачиваем очищенную строку
//         string reversedString = new string(cleanedString.Reverse().ToArray());

//         // Сравниваем исходную очищенную строку с перевернутой
//         return cleanedString == reversedString;
//     }
// }

// // --------------------------------------------


// // Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// // Сформировать строку, в которой слова расположены в обратном порядке. 
// // В полученной строке слова должны быть также разделены пробелами.


using System;

class Program
{
    static void Main()
    {
        string inputString = "This is a sample string";

        // Формируем строку с обратным порядком слов
        string reversedString = ReverseWords(inputString);

        // Выводим результат
        Console.WriteLine($"Исходная строка: {inputString}");
        Console.WriteLine($"Строка с обратным порядком слов: {reversedString}");
    }

    static string ReverseWords(string input)
    {
        // Разбиваем строку на слова
        string[] words = input.Split(' ');

        Array.Reverse(words);

        // Собираем перевернутые слова в новую строку
        string reversedString = string.Join(" ", words);

        return reversedString;
    }
}




