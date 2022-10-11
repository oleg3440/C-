int a = new Random().Next(10000, 100000);
Console.Write($"{a}\n");

int b1 = a % 10;

if  (a < 100)
    Console.Write("третьей цифры нет");
else 
    Console.Write(b
    




int a = new Random().Next(10000, 100000);
int.TryParse(Console.ReadLine()!, out a);

string s = a.ToString();

if (s.Length < 3)
    Console.Write($"Третьей цифры нет");
else
    Console.Write($"{s[2]}");