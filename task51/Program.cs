// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящейся
//на главной диагонали с индексами (0, 0); (1, 1) и т.д.
// Например, задан массив:
//1 4 7 2
//5 9 2 3 
//8 4 2 4
// Скмма элементов главной диагонали: 1+9+2 = 12

int[,] array = new int [4, 3];

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

int minSize = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
int sum = 0;

for (int i = 0; i < minSize; i++)

{

        sum += array[i, i];
}    
    Console.WriteLine(sum);

