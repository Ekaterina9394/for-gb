﻿// Задайте двумерный массив размера m  на n
//каждый элемент в массиве находится по формуле
// A(mn) = m+n. Выведите полученный массив на экран
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
       {

        for (int j = 0; j < n; j++)
        {
            result[i, j] = i +j;
        }
       }
       return result;
}

void PrintArray(int[,] array)
{
      for (int i = 0; i < array.GetLength(0); i++)
       {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
       }
}

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n);
PrintArray(myArray);