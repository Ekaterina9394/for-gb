﻿// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] UnevenSum(int[] array)
{
     int[] res = new int[1];

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            res[0] += array[i];
        }
    }
    return res;
}

int[] myArray = GetArray(5, -10, 10);
Console.WriteLine(String.Join(" ", myArray));
int[] result = UnevenSum(myArray);
Console.WriteLine(String.Join(" ", result));


