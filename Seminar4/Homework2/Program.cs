// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
    string result = "";
    int sum = 0;

Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");

do
{

    Console.Write($"Введите положительное целое число (0 - завершить работу): ");
    val1 = ReadInt();
    if (val1 == 0) continue;
    
    result = "";
    sum = 0;
    result = val1.ToString();

    foreach(char c in result) sum = sum + Convert.ToInt32(c.ToString());
    Console.WriteLine($"{val1} -> {sum} ");
   
} while (val1 != 0);
