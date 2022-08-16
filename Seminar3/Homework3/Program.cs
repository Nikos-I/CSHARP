// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadInt() // Ввод целого числа. 0 - особый случай
{
    int val1;
    var valstr = (string?)null;
    do
    {
        Console.Write($"Введите положительное целое число (0 - завершить работу): ");
        valstr = Console.ReadLine();
        if (!(String.IsNullOrEmpty(valstr)) && (int.TryParse(valstr, out val1))) return val1;   
         
        Console.WriteLine("Ошибка ввода");
    }
    while (true);
}
string  result = "";
 int n =  -1;

do
{
    n = ReadInt();
    for (int i=1; i <= n; i++)
    {
        if (i == 1) result = Convert.ToString(Math.Pow(i, 3));
        else result = result + "," + Convert.ToString(Math.Pow(i, 3));
    }
    if (n > 0) Console.WriteLine($"{n} -> {result}");
} while (n != 0);
