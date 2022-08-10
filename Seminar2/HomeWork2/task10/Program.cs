//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    string[] errmsg = {"Значение меньше 100","Значение больше 999"};
    int val1 = 0;
    int retval = 0;
    int SecNumber(int val2)
        {
            if (val2 < 100) { return -1;}
            else if (val2 > 999) { return -2;}
            
            return (val2 / 10) % 10;
        }

    Console.Write("Введите трехзначное число: ");
    val1 = Convert.ToInt32(Console.ReadLine());    

    retval = SecNumber(val1);   

    if (retval >= 0) { Console.WriteLine($"{val1} -> {retval}"); }
    else { Console.WriteLine(errmsg[Math.Abs(retval) - 1]); }

