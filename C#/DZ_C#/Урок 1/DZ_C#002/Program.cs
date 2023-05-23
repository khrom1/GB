// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        Console.WriteLine("Введите a =");
        a = inputValue();
        Console.WriteLine("Введите b =");
        b = inputValue();
        Console.WriteLine("Введите c =");
        c = inputValue();
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Max a=" + a);
            }
            else
            {
                Console.WriteLine("Max c=" + c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Max b=" + b);
            }
            else
            {
                Console.WriteLine("Max c=" + c);
            }
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
