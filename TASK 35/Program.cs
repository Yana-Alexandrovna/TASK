// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,200); // Сделала ограничение по диапазону, иначе на чисто "случайных" ответ в большинстве случаев 0, из-за слишком крупных чисел
    }
    return array;
}

int[] array = new int [123];    
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
int j = 0;
for (int i = 0; i < array.Length; i++)
    if(array[i] <= 99 && array[i] >= 10 )
    {
        j++;
    }
Console.WriteLine(j);
    