//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет



Console.WriteLine("Введите номер ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a == 1 ) Console.Write("Нет"); 
else if ( a == 2 ) Console.Write("Нет"); 
else if ( a == 3 ) Console.Write("Нет"); 
else if ( a == 4 ) Console.Write("Нет"); 
else if ( a == 5 ) Console.Write("Нет"); 
else if ( a == 6 ) Console.Write("Да"); 
else if ( a == 7 ) Console.Write("Да"); 
else Console.Write("Ошибка"); 


