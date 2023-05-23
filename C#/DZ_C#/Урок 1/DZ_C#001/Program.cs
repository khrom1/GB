//  Задача 2:Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a;
        double b;
        
        Console.WriteLine("Введите a =");
        a = inputValue();
        Console.WriteLine("Введите b =");
        b = inputValue();
        if (a < b)
        {
            Console.WriteLine("max b=" + b);
        }
        else
        {
            Console.WriteLine("max a=" + a);
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

