int a = new Random().Next(1, 1000);

Console.Write($"{a} → ");

int b1 = a % 10;

if  (a < 100)
    Console.Write("третьей цифры нет");
else 
    Console.Write(b1);