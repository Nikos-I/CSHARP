// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int index = 4;
int sum_odd = 0;
int low = -20;
int high = 120;
 
int[] result = new int[index];
Random rnd = new Random();

Console.WriteLine($"Программа задаёт массив из {index} элементов, заполненный случайными числами от {low} до {high} и выводит на экран сумму элементов, стоящих на нечётных позициях.");    

for (int i = 0; i < result.Length; i++)
{
    result[i] = rnd.Next(low, high);
    if (i%2 != 0) sum_odd += result[i];
}
System.Console.Write("[");
for (int i = 0; i <result.Length; i++)
{
    System.Console.Write($"{result[i]}, ");
}
System.Console.Write($"\b\b] -> {sum_odd}");
