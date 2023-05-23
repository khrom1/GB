//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int value;
        
        Console.WriteLine("Введите цифру обозначающую день недели");
        value = (int) inputValue();
        if (value > 0 && value < 8)
        {
            if (value > 0 && value < 6)
            {
                Console.WriteLine("Увы сегодня будний день");
            }
            else
            {
                Console.WriteLine("Ура сегодня выходной");
            }
        }
        else
        {
            Console.WriteLine("ERROR Эта цифра не день недели");
        }
    }
    

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
