// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


void PrintSum(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}

int Sum(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + Sum(m, n);
        return sum;
    }
}

 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < n)
{
PrintSum(m, n);
}
else if (n < m)
{
PrintSum(n, m);
}
else
{
  Console.Write(0);  
}