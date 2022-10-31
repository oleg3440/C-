//*Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8        */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int size = N > 2 ? N : 2;

int[] array = new int[size];

array[0] = 0;
array[1] = 1;

for (int i = 2; i < N; i++)
    array[i] = array[i - 1] + array[i - 2];

for (int i = 0; i < N; i++)
    Console.Write($"{array[i]} ");

/* **Задача 44:2 решение Не используя рекурсию, выведите первые N чисел 
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int a = 0;
int b = 1;

Console.Write($"{a} {b} ");

for (int i = 0; i < N - 2; i++)
{
Console.Write($"{a + b} ");
b = a + b;
a = b - a;
}