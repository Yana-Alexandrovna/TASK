// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координату х первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату у первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1 , 2)+ Math.Pow(y2-y1 , 2));

Console.WriteLine("Расстояние между точками в 2D пространстве " + d);
