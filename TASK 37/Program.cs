// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10); //Сделала ограничение по диапазону, так легче проверить
    }
    return array;
}

int[] array = new int [5];
array = FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
int i = 0;
int newLength = array.Length/2 + array.Length%2;
int[] newarray = new int [newLength];  
while (i < newLength)
{ 
newarray [i] = array [i] * array [array.Length - 1 - i];
 i++;
}
if(array.Length % 2 > 0)
{
    newarray[newarray.Length - 1] = array[array.Length/2];
}
Console.WriteLine($"произведение пар чисел: {string.Join(", ", newarray)}");
