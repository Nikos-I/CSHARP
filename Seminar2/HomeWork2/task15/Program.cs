// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[] weekend = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
int val1 = 0;
do 
{
Console.Write("Введите номер дня недели (0 - завершить работу): ");
    val1 = Convert.ToInt32(Console.ReadLine());    
            
    if ((val1 > 0) && (val1 <= 7) ) Console.WriteLine($"{val1} -> {weekend[val1-1]}"); 
    else if (val1 != 0) { Console.WriteLine("Ошибка"); }
}
while (val1 != 0);
