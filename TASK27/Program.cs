// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int Sum(int numb)
{
 int sum = 0;
 while (numb != 0)
 {
     sum = sum + numb % 10;
     numb = numb / 10;
 }
return sum;
}


Console.WriteLine("Введите число ");
string numb = Console.ReadLine();
 if (int.TryParse(numb, out int n))
    {
        int sum = Sum(n);
        Console.WriteLine(sum);
    }
 else 
Console.Write("Ошибка");


