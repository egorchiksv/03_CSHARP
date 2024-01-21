// Задание 1. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4

// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

int[,] Create2DArray(int row, int col, int min, int max)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void Show2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Change2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i, j] *= arr[i, j];
            }
        }
    }
    return arr;
}

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Пример
//  2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

void SummDiag(int[,] arr)
{
    int sum = 0;
    int minInd = 0;
    if(arr.GetLength(0) > arr.GetLength(1))
    {
        minInd = arr.GetLength(1);
    }
    else
    {
        minInd = arr.GetLength(0);
    }
    for (int i = 0; i < minInd; i++)
    {
       sum += arr[i, i];
    }
    Console.WriteLine(sum);
}

// Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int [] Average2Array(int [,] arr)
{
    int [] array = new int [arr.GetLength(0)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int avarage = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            avarage += arr[i,j];
        }
        array[i] = avarage / arr.GetLength(1);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach(int i in arr)
    {
        Console.Write($"{i} ");
    }
}


Console.Write("Введите кол-во строк ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DArray(row, col, min, max);
Show2DArray(array);
Console.WriteLine();
ShowArray(Average2Array(array));
//SummDiag(array);
// int[,] changedArray = Change2DArray(array);
// Show2DArray(changedArray);
