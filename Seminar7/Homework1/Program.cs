// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
int valMin = -10;
int valMax = 10;
double[,] array = new double[m, n];

void ArrayFillRandom(ref double[,] arrayP, int valMin, int valMax)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayP.GetLength(0); i++)
        for (int j = 0; j < arrayP.GetLength(1); j++)
            arrayP[i, j] = Convert.ToDouble(rnd.Next(valMin, valMax)) + rnd.NextDouble();
}

void Print2DArray(ref double[,] arraySrc)
{
    for (int i = 0; i < arraySrc.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < arraySrc.GetLength(1); j++)
            System.Console.Write($"{arraySrc[i, j]:F1} ");
    }
    System.Console.WriteLine();
}


ArrayFillRandom(ref array, valMin, valMax);
Print2DArray(ref array);

