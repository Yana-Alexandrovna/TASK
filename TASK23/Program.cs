// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (N < 0) 
{
     Console.WriteLine ("Ошибка ввода: введено отрицательное число");
    
}
else while (i!=N+1)
{
    double square= Math.Pow(i , 3);
    Console.WriteLine (square + " ");
   i++;
}