﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        short number3 = 32767;
        int number1 = 2147483647;
        long number2 = -9223372036854775807;
        Console.WriteLine("Number1 is {0}", number1);
        Console.WriteLine("Number2 is {0}", number2);
        Console.WriteLine("Number3 is {0}", number3);

        Console.ReadLine();
    }
}