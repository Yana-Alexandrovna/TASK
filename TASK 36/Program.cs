// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10); //Сделала ограничение по диапазону, так легче проверить
    }
}
    return array;


int[] array = new int [5];
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if(i%2!=0)
    {
        sum+=array[i];
    }
}

Console.WriteLine(sum);
