/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out M);

int N;
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

Sum(M, N);

void Sum(int M, int N)
{
    Console.Write(Summa(M - 1, N));
}

int Summa(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        result = M + Summa(M, N);
        return result;
    }
}