﻿// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] EvenCount(int[] array)
{
     int[] res = new int[1];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res[0] = res[0] + 1;
        }
    }
    return res;
}

int[] myArray = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", myArray));
int[] result = EvenCount(myArray);
Console.WriteLine(String.Join(" ", result));


