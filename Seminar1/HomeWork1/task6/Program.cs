// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;

//Создание объекта для генерации чисел
Random rnd = new Random();

int value1 = rnd.Next(0,20); //Получить очередное случайное число
string result = "";
if ((value1 % 2) == 0) 
{
    result = "да";
}
else
{
    result = "нет";
}

Console.WriteLine($"value1={value1} -> {result}");

