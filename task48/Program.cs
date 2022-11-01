// **Задача 486** Задайте двумерный массив размера m на n, каждый элемент в массиве
// находится по формуле: Amn = m + n
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

int[,] array = new int [3, 4];

for (int i = 0; i < 3; i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}



