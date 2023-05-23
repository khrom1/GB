// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Введите число");
        a = (int) inputValue();
        if (a % 2 == 0)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("Нет");
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
