//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
a=-a;
int b = a.ToString().Length;
int c = 1;
if ( b < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
 while (b > 3)
 {
  c = c * 10;
  b = b - 1;
 }
int d = (a / c) % 10;
Console.WriteLine("Третья цифра " + d);
}
