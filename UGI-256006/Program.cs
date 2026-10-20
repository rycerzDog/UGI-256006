using System;

class Program
{
    static double F(double a, double angle, double b)
    {
        double t = Math.Tan(angle);

        return Math.Sqrt((a + t * t) / b);
    }

    static void Main()
    {
        double x;

        x = F(1, 2, 3) + F(5, 3, 8) + F(1, 5, 6);

        Console.WriteLine("x = " + x.ToString("F3"));
    }
}