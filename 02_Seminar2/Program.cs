// Напишите программу, которая принимает на вход трёзначное число
// и удаляет вторую цифру этого числа

/*
int num = 345;
num = Math.Abs(num);
int first_dig = num/100;
int second_dig = num%10;
Console.Write($"{first_dig}{second_dig}");
*/

// Напишите программу, которая принимает на вход
// трехзначное число и возводит вторую цифру этого чило в степень,
// равную третьей цифре.

/*
int num = 254;
num = Math.Abs(num);
int first_dig = (num%100)/10;
int second_dig = num%10;
int pow = 1;
for (int i=1; i<=second_dig;i++){
    pow = pow*first_dig;
}
Console.Write(pow);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе чило кратным первому. Если второе число некратно перовому,
// то программа выводит остаток от деления.

/*
int first_num = 16;
int second_num = 8;

if (first_num%second_num == 0){
    Console.Write("Да");
}
else{
    Console.Write($"Нет, {first_num%second_num}");
}
*/

// Напишите программу, которая выводит третью с начала цифру заданного
// числа или сообщает, что третьей цифры нет.

int num = 12345678;
if (num>99){
    while(num>999)
    {
        num /= 10;
    }
    Console.Write($"Third digit is {num%10}");
}
else{
    Console.Write("Нет 3 цифры!");
}