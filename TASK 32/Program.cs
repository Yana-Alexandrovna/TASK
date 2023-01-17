// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}

int[] array = new int [5];
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        array[i] *= -1;
    }
    else
    {
        array[i] *= -1;
    }

}

Console.WriteLine(string.Join(", ", array));


