// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt() // Ввод целого числа..
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

int M = 5;
int count_pos = 0;
int[] result = new int[M];

Console.WriteLine($"Программа вводит с клавиатуры M={M} чисел. Выводит количество чисел больше 0.");    

for (int i = 0; i < M; i++)
{
    result[i] = ReadInt();
    if (result[i] > 0) count_pos += 1;
}
System.Console.Write("[");
for (int i = 0; i <result.Length; i++)
{
    System.Console.Write($"{result[i]}, ");
}
System.Console.Write($"\b\b] -> {count_pos}");
