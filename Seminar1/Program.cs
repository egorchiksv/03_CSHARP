// Напишите программу, которая на вход принимает два целых и
// проверяет, является ли первое число квадратом второго.

/*int num1 = 24;
int num2 = 0;

if (num2 * num2 == num1){
    Console.Write($"{num1} is quater of {num2}");
}
else{
    Console.Write($"{num1} is not quater of {num2}");
}*/

// Напишите программу, которая на вход принимает целое число N,
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
int num = -5;
int num1 = num * (-1);

if (num > num1)
{
    for (int i = num1; i <= num; i++)
    {
        Console.Write($"{i} ");
    }
}
else
{
    for (int i = num; i <= num1; i++)
    {
        Console.Write($"{i} ");
    }
}*/

// Напишите программу, которая принимает на вход трёхзначное целое
// число и на выходе показывает сумму первой и последней цифры этого числа.
// 456 -> 10

int num = -468;
int num_abs = Math.Abs(num);
if (num_abs > 99 && num_abs < 1000)
{
    int first_digit = num_abs / 100;
    int third_digit = num_abs % 10;
    int sum = first_digit + third_digit;
    Console.Write(sum);
}
else {
    Console.Write("Num is not 3 digit");
}

