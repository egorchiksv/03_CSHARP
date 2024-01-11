// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

/*int num = 6;
int [] array = new int [5] { 1, 2, 3, 4, 5 };
bool flag = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        flag = true;
    }
    
}
if (flag)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}*/

//Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

/*int [] array = new int [10] { -1, 2, -3, 4, -5, -6, -7, 8, -9, 0};

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write($"{array[i]} ");
}*/

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новый массив.

// int [] array = { 2, 3, 1, 7, 5, 6, 3};
// int [] parArr = new int [array.Length/2];

// for (int i = 0; i < parArr.Length; i++)
// {
//     parArr[i] = array[i] * array[array.Length-1-i];
//     Console.Write($"{parArr[i]} ");
// }
// if(array.Length % 2 == 1)
// {
//     Console.Write($"(элемент {array[parArr.Length]} не имеет пары)");
// }

// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 

int num = 781;
int [] array = new int [3];
if(num > 99 && num < 1000)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num % 10;
        num /= 10;
        Console.Write($"{array[i]}");
    }
    array.Reverse(); // переворачивание массива
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"{array[i]}");
    }

}
else
{
    Console.WriteLine("Вы ввели не натуральное трехзначное число");
}

//https://www.onlinegdb.com/online_c_compiler
//https://www.programiz.com/c-programming/online-compiler/
//https://www.jdoodle.com/c-online-compiler/