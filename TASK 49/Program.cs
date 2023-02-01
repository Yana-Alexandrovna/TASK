// // Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
matrix[i,j] = new Random().Next(-10, 11);
Console.Write(matrix[i,j] + "\t");
}
Console.WriteLine();
}
Console.WriteLine();
}

void NewMatrix(int[,] matrix, int m, int n)
{
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
if(i%2 == 0 && j%2 == 0)
{
matrix[i,j] = matrix[i,j] * matrix[i,j];
}
Console.Write(matrix[i,j] + "\t");
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
NewMatrix(matrix, m, n);