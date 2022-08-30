// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using System.Linq;

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int ArrayMinSumRowsCol(int[,] arr)
{
    int numbersRow = arr.GetLength(0);
    int numbersCol = arr.GetLength(1);
    int minSum = 0;
    int[] arrTemp = new int[numbersRow];

    for (int i = 0; i < numbersRow; i++)
    {
        arrTemp[i] = 0;
        for (int j = 0; j < numbersCol; j++)
            arrTemp[i] += arr[i, j];
    }
    minSum = arrTemp[0];
    for (int i = 1; i < numbersRow; i++)
        if (minSum > arrTemp[i])
            minSum = arrTemp[i];
    return minSum;
}

void Print2DArrayInt(ref int[,] arraySrc)
{
    int numbersRow = arraySrc.GetLength(0);
    int numbersCol = arraySrc.GetLength(1);

    for (int i = 0; i < numbersRow; i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < numbersCol; j++)
            System.Console.Write($"{arraySrc[i, j]} ");
    }
    System.Console.WriteLine();
}

Print2DArrayInt(ref array);
System.Console.WriteLine($"Минимальная сумма строки: {ArrayMinSumRowsCol(array)}");


