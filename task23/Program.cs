﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i*i*i);
}