// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int value;
        
        Console.WriteLine("Введите трёхзначное число");
        value = (int) inputValue();
        if (value > 99 && value < 1000)
        {
            int res;
            
            res = (int) ((double) (value % 100) / 10);
            Console.WriteLine("Вторая цифра этого числа-   " + res);
        }
        else
        {
            Console.WriteLine("ERROR Вы ввели не трёхзначное число");
        }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

