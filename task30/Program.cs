﻿/* **Задача 30:**

Напишите функцию, которая возвращает массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int[] array = CreateArray();
                             //foreach помогает выводить элементы массива, но в нем нельзя изменять item, значение  
foreach (var item in array)  //item определяет каждый элемент в array
Console.Write($"{item} ");

int[] CreateArray()
{
int[] _array = new int[8];
for (int i = 0; i < _array.Length; i++)
_array[i] = new Random().Next(0, 2);
return _array;                          
}// написанная нами функция int[] CreateArray() и ее решение ниже взвращвется
// в первую строку CreateArray()
