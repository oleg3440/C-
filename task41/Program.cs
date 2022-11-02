// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int M;
Console.Write($"Введите количество чисел : ");
int.TryParse(Console.ReadLine()!, out M);

int k = 0;

for (int i = 0; i < M; i++)
{
    int a;
    int.TryParse(Console.ReadLine()!, out a);
    if (a > 0)
    k++;
}
Console.Write($"Чисел больше нуля → {k}");

//вариант 2, если не вводить числа 
const int length = 5;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(-1000, 1000);
Console.Write($"{array[i]} ");
}
int k = 0;
for (int i = 0; i < length; i++)
if (array[i] > 0)
k++;
Console.Write($"-> {k}");