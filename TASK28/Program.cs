// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Mult(int N)
{
int mult = 1;
for(int i = 1; i <= N; i++) 
    {
     mult *= i;
    }
   return mult;
}


Console.WriteLine("Введите число ");
string N = Console.ReadLine();
 if (int.TryParse(N, out int n))
    {
        int mult = Mult(n);
        Console.WriteLine(mult);
    }
 else 
Console.Write("Ошибка");
