// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9
// 1234 -> 10

// int SumDigits(int num)
// {
//     if(num == 0)
//     {
//         return 0;
//     }
//     int res = num % 10 + SumDigits(num / 10);
//     return res;
// }

// Console.Write(SumDigits(1234));

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

// void WriteDigits(int num)
// {
//     if(num == 0)
//     {
//         return;
//     }
//         WriteDigits(num - 1); // вывод в прямом порядке
//         Console.Write(num+" "); //

//         // Console.Write(num+" "); //вывод в обратном порядке порядке
//         // WriteDigits(num - 1); // 
        
// }

// WriteDigits(5);

// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

// chat n = 'a';
// char.IsLetter(n); // проверяет является ли данный символ буковой
// char.ToLower(n); // Опускает символ в нижний регистр
// string = "1234";
// str.Substring(1); // функуция перегрузки,  которая убирает символ из строки. В данном случае убирает 1 символ с начала строки

void PrintConsonants(string str)
{
    if(str.Length == 0)
    {
        return;
    }
    string vovels = "aeiuyo";
    if(char.IsLetter(str[0]) && !vovels.Contains(char.ToLower(str[0])))
    {
        Console.Write(str[0] + " ");
    }
    PrintConsonants(str.Substring(1));
}

PrintConsonants("Hello");