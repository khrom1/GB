//Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.

using System;

namespace homework
{
    class Program
    {
        static void Main()
        {
            
            Print("Введите количество элементов массива");
            int Count = Convert.ToInt32(Console.ReadLine());
             Print("Заполните массив");
            int[] array = new int[Count];

            for (int i = 0; i < array.Length; i++)
            {         
                 array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Print("Вывод массива :");
            for (int j = 0; j < array.Length; j++)
            {
                System.Console.WriteLine(array[j]);
            }
        }
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

    }
}
