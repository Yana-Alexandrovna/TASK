// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void Snail(int[,] matrix)
{
int i = 0;
int j = 0;
for(int k = 1; k <= 16; k++){
  matrix[i, j] = k;
  if (i <= j + 1 && i + j < 3)
    j++;
  else if (i < j && i + j >= 3)
    i++;
  else if (i >= j && i + j > 3)
    j--;
  else
    i--;
}
}


void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]}  ");
}
Console.WriteLine();
}
}


int[,] matrix = new int[4, 4];
Snail(matrix);
PrintArray(matrix);
