// **Задача 46 ** Задвйте двумерный массив mxn, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 - 2 33 - 2
// 77 3 8 1

int[,] array = new int [3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(10);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}

//второй вариант сокращенный
int[,] array = new int [3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}