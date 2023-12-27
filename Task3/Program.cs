// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

int number = 5;

if (number%2 == 0)
{
    Console.WriteLine($"Число `{number}` чётное");
}
else
{
    Console.WriteLine($"Число `{number}` нечётное");
}