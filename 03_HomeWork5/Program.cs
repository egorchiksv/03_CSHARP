// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9

int[,] Create2DArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// void ShowElement(int[,] arr,int row, int col)
// {
//     Console.Write($"Значение элемента с позицией ({row+1},{col+1}) {arr[row, col]} равно ");
// }

// bool ValPos(int[,] arr,int row, int col)
// {
//     bool pos = false;
//     if(row > 0 && row < arr.GetLength(0) && col > 0 && col < arr.GetLength(1))
//     {
//         pos = true;
//     }
//     return pos;
// }

// Console.Write("Введите кол-во строк ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки элемента ");
// int num_row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца элемента ");
// int num_col = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(row, col);
// Show2DArray(array);
// if(ValPos(array, num_row, num_col))
// {
//     ShowElement(array, num_row-1, num_col-1);
// }
// else
// {
//     Console.Write($"Элемент с позицией ({num_row},{num_row}) не существует");
// }


// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

// int[,] Change2DArray(int[,] arr)
// {
//     int element = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         element = arr[0,j];
//         arr[0,j] = arr[arr.GetLength(0)-1,j];
//         arr[arr.GetLength(0)-1,j] = element;
//     }
//     return arr;
// }

// Console.Write("Введите кол-во строк ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int col = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(row, col);
// Show2DArray(array);
// Console.WriteLine();
// Show2DArray(Change2DArray(array));

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2

// int [] SumRows (int[,] arr)
// {
//     int [] array = new int [arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             array[i] += arr[i, j];
//         }
//     }
//     return array;
// }

// int MinSum(int [] arr)
// {
//     int min = arr[0];
//     int minInd = 0;
//     for(int i = 1; i < arr.GetLength(0); i++)
//     {
//         if(arr[i] < min)
//         {
//             minInd = i;
//         }
//     }
//     return minInd;
// }

// Console.Write("Введите кол-во строк ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int col = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(row, col);
// Show2DArray(array);
// int [] arrSum = SumRows (array);
// Console.Write($"Наименьшая сумма {MinSum(arrSum)} строки ");

// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца.
// 4 3 1 => 2 6
// 2 6 9    4 6
// 4 6 2

void MinElement(int [,] arr)
{
    int min = arr[0, 0];
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min)
            {
                min = arr[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    Show2DArray(Change2DArray(arr, minI, minJ));
}

int[,] Change2DArray(int[,] arr,int minI, int minJ)
{
    int[,] arrCh = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int iCh = 0;
    int jCh = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != minI)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
            if (j != minJ)
            {
                arrCh[iCh, jCh] = arr[i, j];
                jCh++;
            }
            }
            iCh++;
            jCh = 0;
        }
    }
    return arrCh;
}

Console.Write("Введите кол-во строк ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DArray(row, col);
Show2DArray(array);
MinElement(array);