// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ResaltY( double b, double k, double t)
{
    
    double y = k * t + b;
    return y;
}

Console.WriteLine("Введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
Console.WriteLine("Эти прямые лежат друг на друге"); 
else if (k1 == k2 && b1 != b2)
Console.WriteLine("Это параллельные прямые"); 
else 
{
  double x = (b2 - b1) / (k1 - k2);  
 
  Console.Write($" {x} , {ResaltY(b1, k1, x)}" );
}  