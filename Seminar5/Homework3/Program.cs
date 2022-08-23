for (int i = 0; i < length; i++)
{
    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3 7 22 2 78] -> 76

    int index = 4;
    double diff = 0;
    double min = 0;
    double max = 0;
    double high = 100;
    double[] result = new double[index];
    Random rnd = new Random();

    Console.WriteLine($"Программа задаёт массив из {index} элементов, заполненный случайными числами от 0 до {high:F3} и выводит на экран разницу между максимальным и минимальным значениями элементов массива.");

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble() * high;
        if (i == 0) min = result[i]; else if (result[i] < min) min = result[i];
        if (i == 0) max = result[i]; else if (result[i] > max) max = result[i];
    }
    for (int i = 0; i < length; i++)
    {

        System.Console.Write("[");
        for (int i = 0; i < result.Length; i++)
        {
            System.Console.Write($"{result[i]:F3}, ");
        }
        diff = max - min;
        System.Console.WriteLine($"\b\b] -> {diff:F3}");

    }
}