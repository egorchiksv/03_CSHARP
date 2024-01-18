// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Console.Clear();
// string result = "";
// string InputDigit(string digit)
// {
//     string res = "";
//     int sum = 0;
//     int dig = Convert.ToInt32(digit);
//     while(dig%10 != 0)
//     {
//         sum = sum + dig%10;
//         dig /= 10;
//     }
//     if(sum%2 == 0 && sum !=0)
//     {
//         res = "STOP";
//     }
//     return res;
// }

// while(result != "STOP")
// {
//     Console.Write("Введите число: ");
//     string digit = Console.ReadLine();
//     if(digit == "q")
//     {
//         result = "STOP";
//     }
//     else
//     {
//         result = InputDigit(digit);
//     }
// }

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Clear();

// int [] GreateRandomArray (int N)
// {
//     int[] array = new int[N];
//     for(int i = 0; i < N; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     foreach (int e in array)
//     {
//         Console.Write($"{e} ");
//     }
//     Console.WriteLine();
// }
// void NumberEven(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     Console.Write($"Количество четных элементов = {count}");
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = GreateRandomArray(size);
// ShowArray(array);
// NumberEven(array);

// Задача 3: Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. Сформируйте целое число, 
// которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.

// Console.Clear();

// int [] GreateRandomArray (int N)
// {
//     int[] array = new int[N];
//     for(int i = 0; i < N; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     foreach (int e in array)
//     {
//        Console.Write($"{e} ");
//     }
//     Console.WriteLine();
// }
// void GreateNumber(int[] array)
// {
//     string str = "";
//     for(int i = 0; i < array.Length; i++)
//     {
//         str = str + Convert.ToString(array[i]);
//     }
//     Console.Write(str);
// }

// Console.Write("Введите количество элементов массива (не более 8): ");
// int size = Convert.ToInt32(Console.ReadLine());
// if(size <= 8)
// {
//     int [] array = GreateRandomArray(size);
//     ShowArray(array);
//     GreateNumber(array);
// }