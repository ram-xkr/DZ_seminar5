// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
Write("Ввведите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] array = GetArray(length);
WriteLine($"[{String.Join(",", array)}]");
chetArray(array);


int[] GetArray(int size)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = rnd.Next(100, 999+1);
    }
    return result;
}


void chetArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        result = result + 1; 
    }
    WriteLine($"Количество чётных чисел в массиве = {result}");
}
