/* **Задача 26:**
Напишите программу, которая принимает на вход число и выдаёт
количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Количество цифр в {a} = {Digits(a)}");

int Digits(int a)
{
int temp = a;  //создаем переменную, чтобы не портить а
int dig = 0;
while (temp != 0)   //проверяем чтобы int temp = a было не равно 0
{
temp /= 10;         //int temp = a делим на 10
dig++;
}
return dig;
}
// вариант 2 нахождение десятичного логарифма этой же задачи
int Digits2(int a)
{
return (int)Math.Log10(a) + 1;
}
