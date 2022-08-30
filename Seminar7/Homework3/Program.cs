// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
double[] result = new double[4];

void ArrayAverCol(int[,] arr, ref double[] res)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            sum += arr[i, j];
        res[j] = 1.0 * sum / arr.GetLength(0);
    }
}

void Print2DArrayInt(ref int[,] arraySrc)
{
    for (int i = 0; i < arraySrc.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < arraySrc.GetLength(1); j++)
            System.Console.Write($"{arraySrc[i, j]} ");
    }
    System.Console.WriteLine();
}

void PrintArrayDouble(ref double[] arraySrc)
{
    System.Console.WriteLine();
    for (int i = 0; i < arraySrc.GetLength(0); i++)
        System.Console.Write($"{arraySrc[i]:f1} ");
    System.Console.WriteLine();
}

ArrayAverCol(array, ref result);
Print2DArrayInt(ref array);
PrintArrayDouble(ref result);

