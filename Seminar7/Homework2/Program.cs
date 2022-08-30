// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int row = 0;
int col = 0;
int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int result = -1;

int ReadInt() // Ввод целого положительного числа. 
{
    int val1;
    var valstr = (string?)null;
    do
    {
        valstr = Console.ReadLine();
        if (!(String.IsNullOrEmpty(valstr)) && (int.TryParse(valstr, out val1)) && (val1 >= 0)) return val1;

        Console.WriteLine("Ошибка ввода");
    }
    while (true);
}

int ArrayVal(int[,] arrayP, int r, int c)
{
    if ((r > arrayP.GetUpperBound(0)) || (c > arrayP.GetUpperBound(1)))
    {
        return -1;
    }
    else
    {
        return arrayP[r, c];
    }
}

void RowColInput(out int r, out int c)
{

    System.Console.WriteLine("Введите позицию элемента:");
    System.Console.Write("row: ");
    r = ReadInt();
    System.Console.Write("col: ");
    c = ReadInt();
}

void ArrayValPrint(ref int[,] array1, int r1, int c1)
{
    result = ArrayVal(array1, r1, c1);
    if (result == -1)
    {
        System.Console.WriteLine($"Нет такого значения row={r1}, col={c1}");
        System.Console.WriteLine($"Размер массива array[{array1.GetLength(0)},{array1.GetLength(1)}]");
    }
    else
        System.Console.WriteLine($"array[{row},{col}] = {result}");
}

RowColInput(out row, out col);
ArrayValPrint(ref array, row, col);
