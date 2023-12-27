// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

int number = 10;

for (int i = 1; i <= number; i++)
{
    if (i%2 == 0)
    {
        Console.Write($"{i}\t");
    }
}