// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

//Создание объекта для генерации чисел
Random rnd = new Random();

int value1 = rnd.Next(0,20); //Получить очередное случайное число
int value2 = rnd.Next(0,20); //Получить очередное случайное число
int value3 = rnd.Next(0,20); //Получить очередное случайное число
int max = value1;

if (value2 > max)  max = value2; 
if (value3 > max) max = value3; 


Console.WriteLine($"value1={value1} value2={value2} value3={value3} ->{max}");
