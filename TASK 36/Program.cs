// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100); // Сделала ограничение по диапазону, для удобной проверки
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int [l];
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
