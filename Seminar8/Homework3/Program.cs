// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int minVal = 10;
int maxVal = 100;
int[,,] array = new int[2, 2, 2];

void ArrayFillRandomInt(int[,,] arr, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
                arr[i, j, k] = rnd.Next(min, max);
}

void Print3DArrayInt(ref int[,,] arraySrc)
{
    int dim1 = arraySrc.GetLength(0);
    int dim2 = arraySrc.GetLength(1);
    int dim3 = arraySrc.GetLength(2);

    System.Console.WriteLine();
    for (int k = 0; k < dim3; k++)
    {
        for (int i = 0; i < dim1; i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < dim2; j++)
                System.Console.Write($"{arraySrc[i, j, k]}({i},{j},{k}) ");
        }
    }
    System.Console.WriteLine();
}

ArrayFillRandomInt(array, minVal, maxVal);
Print3DArrayInt(ref array);



