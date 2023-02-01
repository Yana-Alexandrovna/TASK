// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = i+j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
matrix[i,j] = i+j;
Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);