﻿//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int N = new Random().Next(20);

Console.Write($"{N}\n");

int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");

    i=i+1;
}