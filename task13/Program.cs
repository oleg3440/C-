//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int a = new Random().Next(1, 1000);

Console.Write($"{a} → ");

int b1 = a % 10;

if  (a < 100)
    Console.Write("третьей цифры нет");
else 
    Console.Write(b1);

    // Задача 13: 
Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6       */

int a;
int.TryParse(Console.ReadLine()!, out a);

string s = a.ToString();

if (s.Length < 3)
    Console.Write($"Третьей цифры нет");
else
    Console.Write($"{s[2]}");


int a;
int.TryParse(Console.ReadLine()!, out a);

int temp = a;

if (a < 100)
    Console.Write($"Третьей цифры нет");
else
{
    while (temp >= 1000)
        temp /= 10;
    Console.Write($"{a} -> {temp % 10}");
}

