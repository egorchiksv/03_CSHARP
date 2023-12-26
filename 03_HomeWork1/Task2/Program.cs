// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 9;
int b = 6;
int c = 7;
int max = a;

if (max < b)
{
    max = b;
}  
if (max < c)
{
    max = c;
}    
    
Console.WriteLine($"Максимальное число равно `{max}`");