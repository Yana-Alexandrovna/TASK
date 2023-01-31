// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


void GetBinaryView(int number)
{
if(number == 0) return;
GetBinaryView(number/2);
Console.Write(number%2);
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
GetBinaryView(number);