//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

int[] A = new int[] {7, -5, 0};
int[] B = new int[] {1, -1, 9};

int x = (int)Math.Pow(A[0] - B[0], 2);
int e = (int)Math.Pow(A[1] - B[1], 2);
int y = (int)Math.Pow(A[2] - B[2], 2);

double Ans = Math.Round(Math.Sqrt(x+e+y), 2);

Console.Write($"{Ans} ");