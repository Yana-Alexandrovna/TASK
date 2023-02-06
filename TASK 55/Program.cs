// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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
int[,] ResultMatrix = new int[n,m];

for(int i = 0; i < ResultMatrix.GetLength(0); i++)
{
for(int j = 0; j < ResultMatrix.GetLength(1); j++)
{
ResultMatrix[i,j] = matrix[j, i];
}
}
Console.WriteLine();
PrintArrayWithRandom(ResultMatrix);