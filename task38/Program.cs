/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

const int length = 10;
double[] array = new double[length];
for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(100) / (double)10;
Console.Write($"{array[i]} ");
}
double min = array[0], max = array[0];
for (int i = 0; i < length; i++)
{
if (array[i] > max)
max = array[i];
if (array[i] < min)
min = array[i];
}

Console.Write($"-> {max - min}");