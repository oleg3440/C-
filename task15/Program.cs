﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

int a = new Random().Next(1, 8);

Console.Write($"{a} → ");

if  (a < 6)
    Console.Write("нет");
else 
    Console.Write("да");


//      Задача 15:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет       //

int a;
int.TryParse(Console.ReadLine()!, out a);

if (a == 6 || a == 7)
    Console.Write($"{a} -> Да");
else
    Console.Write($"{a} -> Нет");