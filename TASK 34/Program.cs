// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
//[345, 897, 568, 234] -> 2

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int[] array = new int [10];    
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив из трехзначных чисел: ");
Console.WriteLine(string.Join(", ", array));
int j = 0;
for (int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0)
    {
        j++;
    }
Console.WriteLine(j);
    



