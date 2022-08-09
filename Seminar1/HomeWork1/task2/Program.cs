// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;

//Создание объекта для генерации чисел
Random rnd = new Random();

int value1 = rnd.Next(0,20); //Получить очередное случайное число
int value2 = rnd.Next(0,20); //Получить очередное случайное число
int max;
if (value1 > value2) {
   max = value1; 
} 
else
{
   max = value2; 
}

Console.WriteLine($"value1={value1} value2={value2} max={max}");


