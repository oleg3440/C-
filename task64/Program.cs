/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
int N;
Console.WriteLine($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

void Output (int N)
{
  if (N == 0)
  return;
  Console.Write("{0, 4}", N);
  Output (N - 1);
}
Output(N);