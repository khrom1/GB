//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


using System;

class Program
{
    static void Main()
    {
        Random RandonNumbers = new Random();
        int[] array = new int[4];
        Console.WriteLine("Заданный массив случайных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = RandonNumbers.Next(-99, 99);
            Console.Write(array[i] + " ");
        }
        int result = 0;
        for (int i = 1; i < array.Length; i += 1)
        {
            if (i % 2 != 0) result += array[i];
        }
        Console.WriteLine();
        Console.WriteLine("Cумма элементов, стоящих на нечётных позициях =" + result);
    }
}