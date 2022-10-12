//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int a;
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"{a}\n");
int b = a % 10;
int c = a / 10 % 10;
int d = a / 1000 % 10;
int e = a / 10000;
if (b==e && c==d)
Console.WriteLine ("число является полиандром");
else
Console.WriteLine ("число не является полиандром");

