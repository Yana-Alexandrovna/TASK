// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintFib(int n)
{
Console.Write("0 1 ");
int neighbour1 = 0;
int neighbour2 = 1;
int res = 0;
for(int i = 0; i < n - 2; i++)
{
res = neighbour1 + neighbour2;
Console.Write(res + " ");
neighbour1 = neighbour2;
neighbour2 = res;
}
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintFib(N);