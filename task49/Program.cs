﻿// **Задача 49:** Задайте двумерный массив. Надите элементы, у которых оба
//номера четные, и замените их на квадраты.
//1 4 7 2 
//5 9 2 3 
// 4 2 4

//1 4 7 2
//5 81 2 9 
//8 4 2 4

int[,] array = new int [3, 4];

for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 != 0 && j % 2 !=0)
            array[i, j] *= array[i, j];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}