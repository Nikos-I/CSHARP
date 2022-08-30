// ** доп задача
// ** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrixSource1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrixSource2 = new int[,] { { 3, 4 }, { 3, 3 } };
int[,] matrixResult = new int[matrixSource1.GetLength(0), matrixSource2.GetLength(1)];

int[,] MatrixMulti(int[,] matrixSrc1, int[,] matrixSrc2)
{
    int Rows1 = matrixSrc1.GetLength(0);
    int Cols1 = matrixSrc1.GetLength(1);
    int Rows2 = matrixSrc2.GetLength(0);
    int Cols2 = matrixSrc2.GetLength(1);
    int[,] matrixRes = new int[Rows1, Cols2];
    
    for (int mRow1 = 0; mRow1 < Rows1; mRow1++) // цикл по строкам матрицы 1  
        for (int mCol2 = 0; mCol2 < Cols2; mCol2++) // для каждой строки матрицы 1 цикл по столбцам матрицы 2
            for (int mCol1 = 0; mCol1 < Cols1; mCol1++) // цикл по столбцам матрицы 1 
                matrixRes[mRow1, mCol2] += matrixSrc1[mRow1, mCol1] * matrixSrc2[mCol1, mCol2]; // вычисление скалярного произведения
    return matrixRes;
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

Print2DArrayInt(ref matrixSource1);
Print2DArrayInt(ref matrixSource2);
matrixResult = MatrixMulti(matrixSource1, matrixSource2);
Print2DArrayInt(ref matrixResult);
