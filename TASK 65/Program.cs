// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.
// M = 1; N = 5 -> "1,2,3,4,5"
// M = 4; N = 8 -> "4,6,7,8"


 void PrintNumbers(int number1, int number2)
{
   
    if(number1 == number2 - 1)
    {
        return;
    }
PrintNumbers(number1 - 1, number2);
Console.Write(number1 + " ");
}

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbers( M , N );