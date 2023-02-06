// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void FillArrayWithRandom(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(0, 10);
}

}
}

void PrintArrayWithRandom(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + "\t");
}
Console.WriteLine();
}
Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] matrixresult = new int[m, n];
FillArrayWithRandom(matrix1);
PrintArrayWithRandom(matrix1);
FillArrayWithRandom(matrix2);
PrintArrayWithRandom(matrix2);

for (int i = 0; i < matrixresult.GetLength(0); i++)
  {

    for (int j = 0; j < matrixresult.GetLength(1); j++)
    {
        int sum = 0;
      for (int k = 0; k < matrixresult.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j]; 
      }
     matrixresult[i,j] = sum;
    }
  
  }
PrintArrayWithRandom(matrixresult);
//matrixresult[i,j] = matrix1[i,j] * matrix2[i,j] + matrix1[i,k] * matrix2[k, j]; 
