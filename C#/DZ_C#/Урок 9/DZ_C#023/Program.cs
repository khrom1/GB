﻿//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите натуральное число M:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите натуральное число N:");
        int n = Convert.ToInt32(Console.ReadLine());

        void OutputSum(int m, int n, int sum)
        {

            if (m > n)
            {

                Console.Write($"Cумму натуральных элементов в промежутке от M до N : {sum}");
                return;
            }


            sum = sum + (m++);
            OutputSum(m, n, sum);
        }
        OutputSum(m, n, 0);



    }
}