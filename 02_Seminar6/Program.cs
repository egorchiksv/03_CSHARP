//char ch = 'V';
// string str = "ghjf";
// Console.Write(str[1]);
// char [] ch = new char [str.Length];

// for(int i = 1; i < 2;)
// {
//     str[i] = "E";
// }

// char [] ch = {'a','b','c','d'};
// string str1 = new string(ch);

// string str3 = new string('1', 10); // запишет в память 1 десять раз

// Console.WriteLine(str);
// Console.WriteLine(str1);
// Console.WriteLine(str3);

// string str = "hello";

// for(int i = 0; i < str.Length; i++)
// {
//     str[i] = "E";
// }

// char[] ch = str.ToCharArray();
// ch[1] = 'E';
// str = new string(ch);
// Console.WriteLine(str);

// Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// char [] ch = {'a', 'b', 'c', 'd'};
// string str = "";
// foreach(char e in ch)
// {
//     str +=e;
// }

// Console.Write(str);

// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// string str = "Hello";
// char [] ch = new char [str.Length];
// for(int i = 0; i < str.Length; i++)
// {
//     ch[i] = str[i];
// }
// foreach(char e in ch)
// {
//     Console.Write(e+" ");
// }