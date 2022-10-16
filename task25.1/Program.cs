/*      Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int a, b;
Console.Write($"Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out b);

int Poww(int a, int b)
{
    int ans = a;
    for (int i = 1; i < b; i++)
        ans *= a;
    return ans;
}

Console.WriteLine(Poww(a, b));

