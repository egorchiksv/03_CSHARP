// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// void PrintNumbers(int min, int max)
// {
//     if(min == max)
//     {
//         Console.Write(min);
//         return;
//     }
//     Console.Write($"{min}, ");
//     min += 1;
//     PrintNumbers(min, max);
// }
// Console.WriteLine("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if(M > N)
// {
//     int NM = N;
//     N = M;
//     M = NM;
// }
// if(M <= 0 | N <= 0)
//     Console.Write("Введены ненатуральные числа");
// else
//     PrintNumbers(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример
// m = 2, n = 3 -> A(m,n) = 29

// int A(int n, int m)
// {
//     if(n == 0) return m + 1;
//     if(m == 0) return A(n - 1, 1);
//     return A(n - 1, A(n, m - 1));
// }
// Console.WriteLine("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if(N >= 0 || M >= 0) Console.Write(A(N, M));
// else Console.Write("Числа должны быть неотрицательными");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void ReversArray(int[] arr, int n)
{
    if(n < 0) 
    {
        return;
    }
    Console.Write($"{arr[n]} ");
    n -= 1;
    ReversArray(arr, n);
}

int [] array = {1, 2, 5, 0, 10, 34};
ReversArray(array, array.Length-1);