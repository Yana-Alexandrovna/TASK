// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

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

void NewMatrix(int[,] array, int rows, int columns)
{
int sum = 0;
for(int i = 0; i < rows; i++)
{
for(int j = 0; j < columns; j++)
{
if(i == j)
{
sum += array[i,j];
}

    }
}
Console.Write(sum);
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);
NewMatrix(matrix, m, n);