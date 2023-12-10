using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(m, n);

        Console.ReadLine();
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNumbers(m + 1, n);
        }
    }
}