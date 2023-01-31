// Задача 39: Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т. д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 8 6] -> [6 3 7 6]


void FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void ReverseArray(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] array = new int [11];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
ReverseArray(array);
Console.Write("Ваш перевернутый массив: ");
Console.WriteLine(string.Join(", ", array));




