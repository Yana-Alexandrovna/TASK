// // Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

void Resalt(int A, int B, int C)
{
 if(A < B + C && B < A + C && C < A + B )
  Console.WriteLine("Такой треугольник существует");
 else 
  Console.WriteLine("Такой треугольник не существует");
}



Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
Resalt(a, b, c);