// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int[] Array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.WriteLine("Введите размер массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int [l];
Console.WriteLine("Задайте массив: ");
Array(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
bool number = false;
for(int i = 0; i < array.Length; i++)
{
    if(a==array[i])
    {
        number = true;
        break;
    }
}
if(number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



