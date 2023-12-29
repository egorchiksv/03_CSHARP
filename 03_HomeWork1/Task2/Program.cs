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
/*
int max = 0;
   if (a > b)
    {
        if (a > c)
        {
          max = a;
        }
         if (c > a)
         {
           max = c;
         }
     }
     else
     {
         if (b > c)
         {
          max = b;
         }
         if (c > b)
         {
         max = c;
       }
    }
    return max;
    */