// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.



void FillArrayWithRandom(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
}
}

int[] array1 = new int [5];
FillArrayWithRandom(array1);
int[] array2 = new int [5];
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array1));

for(int i = 0; i < array2.Length; i++)
{
array2[i] = array1[i];
}
Console.Write("Ваш скопированный массив: ");
Console.WriteLine(string.Join(", ", array2));

