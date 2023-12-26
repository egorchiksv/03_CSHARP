// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

int firstNumber = 6;
int secondNumber = 6;

if(firstNumber > secondNumber)
{
    Console.Write($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
if(firstNumber < secondNumber)
{
    Console.Write($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
if(firstNumber == secondNumber)
{
    Console.Write($"Введенные числа равны `{firstNumber}`");
}