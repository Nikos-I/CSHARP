// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;

//Создание объекта для генерации чисел
Random rnd = new Random();
string result = "";
int value1 = rnd.Next(2,20); //Получить очередное случайное число
for (int i = 1; i <= value1; i++)
{
    if ((i % 2) == 0) result = result + " " + i.ToString();
}
Console.WriteLine($"value1={value1} ->{result}");

