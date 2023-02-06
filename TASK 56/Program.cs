// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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



Console.WriteLine("Введите количество столбцов в двумерном массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[2,n];
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < n; i++)
{
sum1 += matrix[0, i];
sum2 += matrix[1, i];
}
if (sum1 < sum2)
Console.WriteLine("сумма элементов в 1 строке меньше");
else if (sum1 > sum2)
Console.WriteLine("сумма элементов в 2 строке меньше");
else
Console.WriteLine("суммы равны");
