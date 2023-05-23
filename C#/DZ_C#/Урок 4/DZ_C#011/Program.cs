//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)

//2, 4 -> 16

using System;

namespace homework
{
    class Program
    {
        public static void Print(string word)
        {
            Console.WriteLine(word);
        }

        static void Main()
        {
            

            Print("Число A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Print("Число B:");
            int B = Convert.ToInt32(Console.ReadLine());
             
             Rate(A, B);
            
           
        }
           public static void  Rate (int A, int B)
           {
                int t = A;

            for (int i = 1; i < B; i++)
            {
                t = t * A;
            }
               Console.WriteLine( A + " в степени "+ B + "= " + t);
           }
    }             
}