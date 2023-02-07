// Задача 69 напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии
// А = 3; B = 5 -> 243
// А = 2; B = 3 -> 8

int Exp(int n, int m)
{
    int exp = 1;
    if(m == 0)
    return exp;
    else return exp = n*Exp(n, m-1);
}


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int exp = Exp(n,m);
Console.WriteLine(exp);