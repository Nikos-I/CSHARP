// Написать алгоритм поворота матрицы [N;N] на 90 градусов

int n = 3;
int[,] a = new int[n, n];
int[,] b = new int[n, n];

void fillArray(ref int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            arr[i, j] = i * 10 + j;
        }
}

int[,] copyArray(ref int[,] arr)
{
    int[,] arr2 = new int[arr.GetUpperBound(0)+1, arr.GetUpperBound(1)+1];
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            arr2[i, j] = arr[i, j];
        }
        return arr2;
}

void printArray(ref int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            System.Console.Write($"{arr[i, j]:D2} ");
        }
    }
    System.Console.WriteLine();
}

// Поворот матрицы на 90 градусов
int[,] rotateArray90(ref int[,] arr)
{
    int[,] arr2 = new int[arr.GetUpperBound(0)+1, arr.GetUpperBound(1)+1];
    int t = 0;

    arr2 = copyArray(ref arr);
    
    // printArray(ref arr2);

    for (int i = 0; i < (n / 2 - 1); i++)
    {
        for (int j = 0; j < (n - i - 2); j++)
        {
            t = arr2[i, j];
            arr2[i, j] = arr2[n - j - 1, i];
            arr2[n - j - 1, i] = arr2[n - i - 1, n - j - 1];
            arr2[n - i - 1, n - j - 1] = arr2[j, n - i - 1];
            arr2[j, n - i - 1] = t;
        }
    }
    return arr2;
}

fillArray(ref a);
printArray(ref a);
b = rotateArray90(ref a);
printArray(ref b);
