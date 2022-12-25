// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string[] quarters = { "х>0 и y >0" , 
                      "х<0 и y >0" , 
                      "х<0 и y <0" , 
                      "х>0 и y <0" , 
                    };

Console.WriteLine("Введите номер четверти ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a >= 1 && a <= 4  )
{
     Console.WriteLine(quarters[a-1]);
}

else 
{
     Console.WriteLine("Ошибка ввода, нет такой четверти");
}

