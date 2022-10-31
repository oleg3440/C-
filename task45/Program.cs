// Создайте программу, котрая будет принимать на вход элементы, которые
// будут записываться в массив, пока Пользователь не введет 0.
List<int> array = new List<int>();

int a;
int.TryParse(Console.ReadLine()!, out a);

while (a !=0)
{
    array.Add(a);
    int.TryParse(Console.ReadLine()!, out a);
}

for (int i = 0; i < array.Count; i++)
{
    Console.Write($"{array[i]} ");
}