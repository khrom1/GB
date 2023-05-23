//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите натуральное число больше 1:");
        int number = Convert.ToInt32(Console.ReadLine());

        void OutputNumbers(int number)
        {
            if (number < 0) Console.Write("Вы ввели не натуральное число");
            if (number == 0) return;
            Console.Write($"{number},");
            OutputNumbers(number -1);
        }

        OutputNumbers(number);



    }
}
