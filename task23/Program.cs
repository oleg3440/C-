//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24  5  -> 120 
int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
int cub = 1;
int c = cub;

Console.Write($"{c}");

{
 for (int i = 1; i <= N; i++);
    c = cub * cub * cub;
    return c;
}




//int Factorial(int a)
//{
  //  int f = 1;
   // for (int i = 2; i <= a; i++)
   //     f = f * i;
  //  return f;
//}



