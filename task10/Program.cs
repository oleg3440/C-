int a = new Random().Next(100, 1000);

Console.Write($"{a} → ");

int b1 = a / 10;
int b2 = b1 % 10; 

Console.Write(b2);