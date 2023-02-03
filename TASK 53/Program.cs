// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

void FillArrayWithRandom(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = new Random().Next(0, 10);
}
}
}

void PrintArrayWithRandom(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i,j] + "\t");
}
Console.WriteLine();
}
Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);

int temp = 0;

for(int i = 0; i < matrix.GetLength(1); i++)
{
temp = matrix[0,i];
matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
matrix[matrix.GetLength(0) - 1, i] = temp;
}
Console.WriteLine();
PrintArrayWithRandom(matrix);