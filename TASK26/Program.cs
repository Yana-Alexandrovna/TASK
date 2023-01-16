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
string q = Console.ReadLine();
 if (int.TryParse(q, out int qq))
    {
        int quantity = Quantity(qq);
        Console.WriteLine(quantity);
    }
    else 
Console.Write("Ошибка");


