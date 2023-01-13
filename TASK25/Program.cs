// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Square(int number1 , int number2 )
{
    int sq = 1;
    for(int i = 0; i < number2; i++)
    {
     sq = sq * number1;
    }
    return sq;
}

Console.Write("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
int square = Square(A , B);
Console.WriteLine(square);

