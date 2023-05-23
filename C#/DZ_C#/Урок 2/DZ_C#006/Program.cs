// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int value;
        Console.WriteLine("Введите число");
        value = (int) inputValue();
        if (value > 99)
        {
            while (value > 999)
            {
                value = (int) ((double) value / 10);
            }
            value = value % 10;
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("ERROR Третьей цифры нет");
        }
    }
    
   
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
