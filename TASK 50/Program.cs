// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7(ввод индексов) -> такого числа в массиве нет
//1, 1 -> 9

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

void Result(int[,]  matrix, int m, int n, int i, int j)
{
    if(i > m || j > n)
    Console.WriteLine("Нет такого числа в массиве");
    else
    Console.WriteLine($"Ваш элемент" + matrix[i,j]);
}


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];  
Console.WriteLine("Ваш массив");
FillArrayWithRandom(matrix, m, n);
Console.WriteLine("Введите номер строки (строки начинаются с нуля 0 1 2 ...):");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца (столбцы начинаются с нуля 0 1 2 ...):");
int j = Convert.ToInt32(Console.ReadLine());
Result(matrix, m, n, i, j);



