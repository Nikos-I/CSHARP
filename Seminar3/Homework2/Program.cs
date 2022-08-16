// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadInt() // Ввод целого числа. 
    {
        int val1;
        var valstr = (string?)null;
        do
        {
            valstr = Console.ReadLine();
            if (!(String.IsNullOrEmpty(valstr)) && (int.TryParse(valstr, out val1))) return val1;   
            Console.Write("Ошибка ввода");
        }
        while (true);
    }
void CoordPoint(string n_point, out int x, out int y, out int z) // Ввод координат точки n_point
    {
        Console.WriteLine($"Введите координаты точки {n_point}");
        Console.Write("Х=");
        x = ReadInt();
        Console.Write("Y=");
        y = ReadInt();
        Console.Write("Z=");
        z = ReadInt();
    }

int Ax, Ay, Az = 0;
int Bx, By, Bz = 0;

CoordPoint("A", out Ax, out Ay, out Az);
CoordPoint("B", out Bx, out By, out Bz);

double dist = 0;
dist = Math.Abs(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)));

Console.WriteLine($"A({Ax},{Ay},{Az}); B({Bx},{By},{Bz}) -> {Math.Round(dist, 2)}");








