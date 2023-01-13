// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Quantity(int numb)
{
  int Q = numb.ToString().Length;
  return Q;
}

Console.WriteLine("Введите число ");
int q = Convert.ToInt32(Console.ReadLine());
int quantity = Quantity(q);
Console.WriteLine(quantity);

