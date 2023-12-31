// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int num = 322;
if (num%7 == 0 & num%23 == 0){
    Console.Write($"Число {num} кратно 7 и 23");
}
else Console.Write($"Число {num} не кратно 7 и 23");
Console.WriteLine();
// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер координатной четверти плоскости, в которой находится эта точка.

int x = 4;
int y = -2;
if (x != 0 & y != 0){
    if(x > 0 & y > 0){
        Console.Write($"Координаты ({x},{y}) находятся в I четверти");
    }
    if(x < 0 & y > 0){
        Console.Write($"Координаты ({x},{y}) находятся в II четверти");
    }
    if(x < 0 & y < 0){
        Console.Write($"Координаты ({x},{y}) находятся в III четверти");
    }
    if(x > 0 & y < 0){
        Console.Write($"Координаты ({x},{y}) находятся в IV четверти");
    }
}
else {
    Console.Write("Координаты не должны быть равны нулю");
}
Console.WriteLine();
// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num1 = 72;
int first_dig = 0;
int second_dig = 0;
if(num1 >= 10 & num1 <= 99){
    first_dig = num1/10;
    second_dig = num1%10;
    if(first_dig > second_dig){
        Console.WriteLine(first_dig);
    }
    if(first_dig < second_dig){
       Console.WriteLine(second_dig); 
    }
    if(first_dig == second_dig){
        Console.WriteLine("Цифры в числе равны");
    }
}
else{
    Console.WriteLine("Число за пределами отрезка [10, 99]");
}
// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую

int N = 9542;
int dig = N;
int d = 1;

while((dig/10) >= 1){
    dig = dig/10;
    d *= 10;
}
while(d > 1){
    Console.Write($"{(N/d)%10}, ");
    d /=10;
}
Console.Write($"{N%10}");