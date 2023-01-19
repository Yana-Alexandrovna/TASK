// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] FillArrayWithRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10); //Сделала ограничение по диапазону, так легче проверить
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int l = Convert.ToInt32(Console.ReadLine());
double [] array = new double [l];
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
double max = 0;
double min = 0;

for (int i= 0; i < array.Length; i++)
    if (array[i]>max)
    {
       max = array[i];
    }
for (int j= 0; j < array.Length; j++)
    if (array[j]<min)
    {
       min = array[j];
    }
double diff = max-min;
Console.WriteLine($"Разница между максимальным и минимальным элементом {diff}");
