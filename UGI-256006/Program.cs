using System;

class Program
{
    static void Main()
    {
        string word = "кинематограф";

        string word1 = word.Substring(8, 4)
                       + word.Substring(7, 1)
                       + word.Substring(4, 2)
                       + word.Substring(2, 1);

        string word2 = word.Substring(4, 3)
                       + word.Substring(9, 1)
                       + word.Substring(7, 1);

        Console.WriteLine(word1);
        Console.WriteLine(word2);
    }
}