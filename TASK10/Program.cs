//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a.ToString().Length;

if (b != 3)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    
int c = a/10;
int d = c%10;
Console.WriteLine("Вторая цифра " + d);

}
