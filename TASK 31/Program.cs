// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительны элементов

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] array = new int [12];
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive+=array[i];
    }
    else
    {
        sumNegative+=array[i];
    }
}

Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}, а сумма положительных числел {sumPositive}" );
