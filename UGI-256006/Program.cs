using System;

class Program
{
    static double F(double x)
    {
        double y;

        y = Math.Sqrt(x * x
            + Math.Sqrt(x * x + 1 / (x * x)));

        return y;
    }

    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        if (x != 0)
        {
            Console.WriteLine("y = " + F(x));
        }
        else
        {
            Console.WriteLine("x не должен быть равен нулю");
        }
    }
}