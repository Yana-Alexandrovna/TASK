// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (N < 0) 
{
     Console.WriteLine ("Ошибка ввода: введено отрицательное число");
    
}
else while (i!=N+1)
{
    double square= Math.Pow(i , 2);
    Console.WriteLine (square + " ");
   i++;
}

