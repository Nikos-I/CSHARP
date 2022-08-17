// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
 //2, 4 -> 16


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
 int A, B, Result =  -1;
 
Console.WriteLine("Цикл принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

do
{
    Console.Write($"Введите положительное целое число A (0 - завершить работу): ");
    A = ReadInt();
    if (A == 0) continue;
    Console.Write($"Введите положительное целое число B (степень): ");
    B = ReadInt();

    for (int i=1; i <= B; i++)
    {
        if (i == 1) Result = A;

        else Result = Result * A;
    }
    if (A > 0) Console.WriteLine($"{A},{B} -> {Result}({A}^{B})");
} while (A != 0);
