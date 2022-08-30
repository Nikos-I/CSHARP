// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using System;
using System.Linq;

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void ArraySortCol(ref int[,] arr)
{
    int numbersRow = arr.GetLength(0);
    int numbersCol = arr.GetLength(1);
    int[] arrTemp = new int[numbersCol];

    for (int i = 0; i < numbersRow; i++)
    {
        for (int j = 0; j < numbersCol; j++)
            arrTemp[j] = arr[i, j];
        arrTemp = arrTemp.OrderByDescending(c => c).ToArray();
        for (int j = 0; j < numbersCol; j++)
            arr[i, j] = arrTemp[j];
    }
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
ArraySortCol(ref array);
Print2DArrayInt(ref array);


