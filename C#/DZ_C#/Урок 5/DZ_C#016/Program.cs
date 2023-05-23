//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


using System;

class Program
{
    static void Main()
    {

        Random RandonNumbers = new Random();
        int[] array = new int[5];
        Console.Write("Заданный массив вещественных чисел: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = RandonNumbers.Next(-99, 99);
            Console.Write(array[i] + " ");
        }
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
        Console.WriteLine();
        Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {min - max}");
    }
}