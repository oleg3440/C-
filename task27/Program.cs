/*      
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int a; int ans = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);


while (a > 0)
{
    ans += a % 10;
    a /= 10;
}

Console.WriteLine(ans);
