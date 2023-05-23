//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main()
    {
        Random RandonNumbers = new Random();
        int[] array = new int[25];
        Console.WriteLine("Заданный массив заполненный случайных положительных трёхзначных чисел:");


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = RandonNumbers.Next(99, 999);
            Console.Write(array[i] + "  ");
        }

        int result = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0) result++;

        Console.WriteLine();
        Console.WriteLine("Количество чётных чисел в массиве равно:  " + result);
    }
}
