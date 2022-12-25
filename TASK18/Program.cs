// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a != 1 && a != 2 && a != 3 && a != 4  )
{
    Console.WriteLine("Ошибка ввода, нет такой четверти");
}

else if (a == 1 )
{
    Console.WriteLine("Диапозон возможных координат х>0 и y >0");
}
else if ( a == 2 )
{
    Console.WriteLine("Диапозон возможных координат х<0 и y >0");
}
else if ( a == 3)
{
    Console.WriteLine("Диапозон возможных координат х<0 и y <0");
}
else if ( a == 4 )
{
    Console.WriteLine("Диапозон возможных координат х>0 и y <0");
}

