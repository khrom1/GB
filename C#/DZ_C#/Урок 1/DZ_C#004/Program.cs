// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        
        Console.WriteLine("Введите N ");
        n = (int) inputValue();
        int i;
        
        i = 2;
        while (i <= n)
        {
            Console.Write(i.ToString() + ",");
            i = i + 2;
        }
    }
    

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

