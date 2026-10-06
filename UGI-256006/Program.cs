using System;

class Program
{
    static void Main()
    {
        double a, b;
        double S, P, D;

        Console.Write("Введите длину прямоугольника: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите ширину прямоугольника: ");
        b = Convert.ToDouble(Console.ReadLine());

        S = a * b;
        P = 2 * (a + b);
        D = Math.Sqrt(a * a + b * b);

        Console.WriteLine("Площадь: " + S);
        Console.WriteLine("Периметр: " + P);
        Console.WriteLine("Диагональ: " + D);
    }
}