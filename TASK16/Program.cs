//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b*b;
int d = a*a;

if ( a == c || b == d) 
Console.Write("Является квадратом"); 
else
Console.Write("Не является квадратом"); 