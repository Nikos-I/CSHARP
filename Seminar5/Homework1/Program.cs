// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int index = 8;
int count_even = 0;
int[] result = new int[index];
Random rnd = new Random();

Console.WriteLine("Программа задаёт массив из 8 элементов, заполненный случайными положительными трёхзначными числами и выводит количество чётных чисел в массиве.");    

for (int i = 0; i < result.Length; i++)
{
    result[i] = rnd.Next(100, 1000);
    if (result[i]%2 == 0) count_even += 1;
}
System.Console.Write("[");
for (int i = 0; i <result.Length; i++)
{
    System.Console.Write($"{result[i]}, ");
}
System.Console.Write($"\b\b] -> {count_even}");
