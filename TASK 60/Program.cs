// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void FillArray(int[, ,] matrix)
{
int a = 0;    
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(2); k++)
{
 matrix[i, j, k] = 10 + a;                  // другой вариант решения =) по факту числа не повторяются до массива 5*5*4 , 
 a++;                                       // по другому уникальность невозможна, т.к. элементов в массиве 5*5*4 = 100 - а это уже 3 значные числа
}
}
}
}

void PrintArray(int[, ,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int k = 0; k < matrix.GetLength(1); k++)
{
Console.Write($"{matrix[i, j, k]} ({i},{j},{k})  ");
}
Console.WriteLine();
}
}
Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число s:");
int s = Convert.ToInt32(Console.ReadLine());
int[, ,] matrix = new int[m, n, s];
FillArray(matrix);
PrintArray(matrix);
