//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//int b; 3, 5 -> 243 (3⁵)  2, 4 -> 16


int a;
int b;
Console.Write($"Введите числа: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите числа: ");
int.TryParse(Console.ReadLine()!, out b);
int Sum(int a, int b) 
{
    int c = a;
    for ( int i = 1; i < b; i++)
        c *= a;
    return c;
}
        Console.WriteLine(Sum (a, b));

