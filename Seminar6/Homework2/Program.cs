// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

Console.WriteLine($"Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; \nзначения b1, k1, b2 и k2 задаются пользователем.");    

System.Console.Write($"b1:");
double b1 = Convert.ToDouble(ReadInt());
System.Console.Write($"k1:");
double k1 = Convert.ToDouble(ReadInt());
System.Console.Write($"b1:");
double b2 = Convert.ToDouble(ReadInt());
System.Console.Write($"k2:");
double k2 = Convert.ToDouble(ReadInt());

double x, y = 0;
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = k1 * x + b1 - y = k2 * x + b2 => 0 =  k1 * x + b1 -k2*x - b2 => (k1-k2)*x  = -(b1-b2)
x = -(b1 - b2) / (k1-k2);
y = k2*x + b2;

System.Console.Write($"[b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}] -> ({x}; {y})");
