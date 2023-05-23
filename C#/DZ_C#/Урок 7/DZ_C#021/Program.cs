// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

class Program
{
    static void Main()
    {
        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
                }
            }
        }
        void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        void ArithmeticalMean(int[,] array)
        {
            Console.Write("Среднее арифметическое элементов в каждом столбце: ");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                }
                double arithmetic = sum / array.GetLength(0);
                Console.Write($"{arithmetic:f1}; ");
            }
        }
        const int Lines = 4;
        const int Columns = 4;
        int[,] array = new int[Lines, Columns];


        CreateArray(array);
        ShowArray(array);
        ArithmeticalMean(array);

    }
}