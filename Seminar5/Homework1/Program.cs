// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int index = 8;
int countEven = 0;
int[] result = new int[index];


int fillAndCalc(ref int[] res)
{
    int countE = 0;
    Random rnd = new Random();
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = rnd.Next(100, 1000);
        if (res[i] % 2 == 0) countE += 1;
    }
    return countE;
}

void writeRes(ref int[] res, int sumOddIn)
{
    System.Console.Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.Write($"{result[i]}, ");
    }
    System.Console.Write($"\b\b] -> {countEven}");
}

Console.WriteLine("Программа задаёт массив из 8 элементов, заполненный случайными положительными трёхзначными числами и выводит количество чётных чисел в массиве.");
countEven = fillAndCalc(ref result);
writeRes(ref result, countEven);
