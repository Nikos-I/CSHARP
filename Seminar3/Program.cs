// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int val2 = -1;


int ReadInt(int dig) // Ввод целого числа разрядности dig. 0 - особый случай
{
    int val1;
    var valstr = (string?)null;
    do
    {
        Console.Write($"Введите {dig} разрядное целое число (0 - завершить работу): ");
        valstr = Console.ReadLine();
        if (!(String.IsNullOrEmpty(valstr)) && (int.TryParse(valstr, out val1)))
        {
            if (
                (val1 == 0) || (((val1 / ( Convert.ToInt32(Math.Pow(10, (dig-1))))) > 0) && ((val1 / ( Convert.ToInt32(Math.Pow(10, (dig-1))))) < 10))
            ) return val1;   
        } 
        Console.WriteLine("Ошибка ввода");
    }
    while (true);
}

string ReverseArray(string str) // Обращение строки
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

do 
{
    val2 = ReadInt(5);
    if (val2 == 0) continue;
    string str1 = Convert.ToString(val2);
    if (str1 == ReverseArray(str1)) Console.WriteLine($"{str1} -> палиндром");
    else Console.WriteLine($"{str1} -> не палиндром");
}
while (val2 != 0);



