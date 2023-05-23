//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1,7 -> такого числа в массиве нет

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

        void CheckNumber(int[,] array)
        {
            Console.WriteLine();
            Console.Write("Введите номер строки- n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер столбца- m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число для проверки: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (array[n - 1, m - 1] == numbers)
            {
                Console.WriteLine($"{numbers} находится на строке  {n}, в столбце  {m}");
            }
            else
            {
                Console.WriteLine($"Числа {numbers} в массиве на строке  {n}, в столбце  {m} нет.");
            }
        }

        const int Lines = 10;
        const int Columns = 10;
        int[,] array = new int[Lines, Columns];


        CreateArray(array);
        ShowArray(array);
        CheckNumber(array);

    }
}