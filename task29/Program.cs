//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
//их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]      6, 1, 33 -> [6, 1, 33]

int[] array = CreateArray();
int[] CreateArray()
{
    int size = 8;
    int[] garray = new int[size];
    for (int i = 0; i < size; i++)
    {
        garray[i] = new Random().Next(10);
        Consol
        
        e.Write($"{garray[i]} ");
    }
    return garray;
}
