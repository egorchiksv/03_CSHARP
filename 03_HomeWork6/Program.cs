
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
// int count_vowels = 0;
// void PrintVowels(string str)
// {
//     if(str.Length == 0)
//     {
//         Console.Write($"В веденной строке {count_vowels} гласных");
//         return;
//     }
//     string vowels = "aeiuyoаоуэыяёеюи";
//     if(char.IsLetter(str[0]) && vowels.Contains(char.ToLower(str[0]))) // Проверяем является ли символ буковой и проверяем есть ли в строке буквы из строки vowels
//     {
//         count_vowels += 1;
//     }
//     PrintVowels(str.Substring(1)); // Удалеем первый символ в строке.
// }

// PrintVowels(Console.ReadLine());

// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// char[,] ch = new char[,] {{'a', 'b', 'c'}, {'d', 'e', 'f'}};
// string GreatString(char[,] array)
// {
//     string str = "";
//     for(int i = 0; i < ch.GetLength(0); i++)
//     {
//         for(int j = 0; j < ch.GetLength(1); j++)
//         {
//             str += ch[i, j];
//          }
//     }
//     return str;
// }

// Console.Write(GreatString(ch));

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string str = "aBcD1ef!";
// string str1 = str.ToLower();
// Console.Write(str1);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом

// string str = "5!56,55";
// bool Palindrom (string str)
// {
//     string str1 = new string (str.Where(char.IsLetterOrDigit).ToArray()).ToLower(); // Удаление знаков
//     return str1.SequenceEqual(str1.Reverse()); // Сравнение строки с ее перевернутым вариантом
// }

// Console.Write(Palindrom(str) ? "Да" : "Нет");

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string str = "Hello my word";

string[] words = str.Split(' '); // Разделяеми строку на отдельные слова
Array.Reverse(words); // Переворачиваем порядок слов
Console.Write(string.Join(" ", words));// Соединяем слова в строку с пробелами и выводим