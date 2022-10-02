// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] array = GetArray(length);
WriteLine($"[{String.Join(",", array)}]");
sumNechet(array);




//создание массива
int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = rnd.Next(0, 9+1);
    }
    return result;
}


//суммирование нечетных элементов массива
void sumNechet(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
    {
        result += array[i];
    }
    WriteLine($"Сумма нечетных элементов массива = {result}");
}

