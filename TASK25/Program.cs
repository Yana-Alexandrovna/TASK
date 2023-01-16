// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Square(int number1 , int number2 )
{
    int sq = 1;
    for(int i = 0; i < number2; i++) // ЦИКЛ!
    {
     sq = sq * number1;
    }
    return sq;
}

Console.Write("Введите первое число ");
string A = Console.ReadLine();
Console.Write("Введите второе число ");
string B = Console.ReadLine();
if (int.TryParse(A, out int a))
{
    if (int.TryParse(B, out int b))
    {
        int square = Square(a , b);
    Console.WriteLine(square);
    }
    else 
Console.Write("Ошибка");
}
else 
Console.Write("Ошибка");
