/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int ReadInt() // Ввод целого числа. 0 - особый случай
{
    int val1;
    var valstr = (string?)null;
    do
    {
        
        valstr = Console.ReadLine();
        if (!(String.IsNullOrEmpty(valstr)) && (int.TryParse(valstr, out val1))) return val1;   
         
        Console.WriteLine("Ошибка ввода");
    }
    while (true);
}

int val1 =  -1;
int index = 8;
int[] result = new int[index];

Console.WriteLine("Программа задаёт массив из 8 элементов и выводит их на экран.");    

do
{
    int j = 0;
    Console.WriteLine($"Введите 'элементы массива (0 - конец ввода): ");
    while ((j < 8) && (val1 != 0))
    {
        Console.Write($"{j}: ");
        val1 = ReadInt();
        result[j] = val1;
        j +=1;
    }
    if ((j==1) && (val1==0)) break;
    Console.WriteLine();
    for (int i=0; (i<index) && (result[i]!=0); i++) Console.Write($"{result[i]},");
    Console.Write("\b -> [");
    for (int i=0; (i<index) && (result[i]!=0); i++) Console.Write($"{result[i]},");
    Console.WriteLine("\b]");
} while (val1 != 0);
