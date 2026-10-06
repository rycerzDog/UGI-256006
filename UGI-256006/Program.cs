using System;

class Program
{
    static void Main()
    {
        int n;
        int b;
        int ac;
        int a;
        int c;
        int x;

        Console.Write("Введите число n: ");
        n = Convert.ToInt32(Console.ReadLine());

        b = n / 100;

        ac = n % 100;

        a = ac / 10;

        c = ac % 10;

        x = a * 100 + b * 10 + c;

        Console.WriteLine("Число x = " + x);
    }
}