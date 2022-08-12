//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string[] errmsg = {"Нет третьей цифры"};
int val1 = 0;
int retval = 0;
int ThirdNumber(int val2)
    {
        val2 = Math.Abs(val2);
        if ((val2 < 100))  return -1;

        return (val2 / 100) % 10;
    }

do 
{
    Console.Write("Введите число (0 - завершить работу): ");
    val1 = Convert.ToInt32(Console.ReadLine());    
    if (val1 == 0) break;

    retval = ThirdNumber(val1);   
    if (retval > 0) Console.WriteLine($"{val1} -> {retval}"); 
    else if (retval < 0) Console.WriteLine(errmsg[Math.Abs(retval) - 1]); 
}
while (val1 != 0);
