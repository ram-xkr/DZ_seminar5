// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] array = GetArray(length);
WriteLine($"[{String.Join(",", array)}]");
raznica(array);




//создание массива
int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = rnd.Next(1, 99+1);
    }
    return result;
}

//вычисление разницы между максимальным и минимальным элементом
void raznica(int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach (var item in array)
    {
        if (item > max)
        {
         max = item;
        }
        if (item < min)
        {
            min = item;
        }
    }
    WriteLine($"Разница между максимальным и мнимальным значением равна {max-min}");
}
