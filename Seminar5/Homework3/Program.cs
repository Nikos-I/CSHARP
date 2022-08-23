// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int index = 4;
double diff = 0;
double high = 100;
double[] result = new double[index];

double calcDiff(ref double[] res, double h)
{
    Random rnd = new Random();
    res[0] = rnd.NextDouble() * h;
    double min = res[0];
    double max = res[0];

    for (int i = 1; i < res.Length; i++)
    {
        res[i] = rnd.NextDouble() * h;
        if (res[i] < min) min = res[i];
        if (res[i] > max) max = res[i];
    };
    return max - min;
}

void writeRes(ref double[] res, double diffInt)
{
    System.Console.Write("[");
    for (int i = 0; i < res.Length; i++) System.Console.Write($"{res[i]:F3}, ");
    System.Console.WriteLine($"\b\b] -> {diffInt:F3}");
}

Console.WriteLine($"Программа задаёт массив из {index} элементов, заполненный случайными числами от 0 до {high:F3} \nи выводит на экран разницу между максимальным и минимальным значениями элементов массива.");
diff = calcDiff(ref result, high);
writeRes(ref result, diff);
