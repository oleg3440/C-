// Двумерный массив
List<List<int>> array = new List<List<int>>();

array.Add(new List<int>()); // создание строк (три строки)
array.Add(new List<int>());
array.Add(new List<int>());

//тоже вверху с for
for (int i = 0; i < 2; i++)
    array.Add(new List<int>());          //вариант 2 с for создание строк
    for (int j = 0; j < 4; j++)
    {
        array [i].Add(new Random().Next(10)); // 2 вариант создание столбцов    
    } 

array[0].Add(5);  // Создание столбцов
array[0].Add(3);
array[0].Add(1);
array[0].Add(1);

array[0].Add(1);  
array[0].Add(9);
array[0].Add(7);
array[0].Add(1);

for (int i = 0; i < array.Count; i++)
{
    for (int j = 0; j < array[i].Count; i++)
    {
        Console.Write($"{array[i][j]} ");
    }
    Console.WriteLine();

}