// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[] weekend = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
int val1 = -1;
var valstr = (string?)null;
do 
{
Console.Write("Введите номер дня недели (0 - завершить работу): ");
valstr = Console.ReadLine();
if (String.IsNullOrEmpty(valstr)) continue;
val1 = Convert.ToInt32(valstr);    
if (val1 == 0) break;
                
if ((val1 > 0) && (val1 <= 7) ) Console.WriteLine($"{val1} -> {weekend[val1-1]}"); 
else if (val1 != 0) { Console.WriteLine("Ошибка"); }
}
while (val1 != 0);
