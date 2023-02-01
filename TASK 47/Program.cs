// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void FillArrayWhithRandom(double[,] matrix, int m, int n) 
{
    for(int i = 0; i < m; i++)
  {
    for(int j = 0; j < n; j++)
    {
      matrix[i,j] = new Random().Next(-10, 10) / 10.0;
      Console.Write(matrix[i,j] + " \t");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m,n];
FillArrayWhithRandom(matrix, m, n);