// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int index = 4;
int sumOdd = 0;
int low = -20;
int high = 120;
int[] result = new int[index];

int calcSum(ref int[] res, int l, int h)
{
    int sumOddIn = 0;
    Random rnd = new Random();
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = rnd.Next(l, h);
        if (i % 2 != 0) sumOddIn += result[i];
    }
    return sumOddIn;
}
void writeRes(ref int[] res, int sumOddIn)
{
    System.Console.Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.Write($"{res[i]}, ");
    }
    System.Console.Write($"\b\b] -> {sumOddIn}");

}
Console.WriteLine($"Программа задаёт массив из {index} элементов, заполненный случайными числами от {low} до {high} и выводит на экран сумму элементов, стоящих на нечётных позициях.");
sumOdd = calcSum(ref result, low, high);
writeRes(ref result, sumOdd);


