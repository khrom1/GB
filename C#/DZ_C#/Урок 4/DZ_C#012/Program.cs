//Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
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
         
            
            Print("Ведите число :");
             {
            int value = Convert.ToInt32(Console.ReadLine());
            
             Degree (value);
                

        }
            static void Degree (int value)
            {
                int Summa = 0;

            while (value > 0)
            {
                Summa += value % 10;
                value = value/10;
                
            }        
              System.Console.WriteLine(Summa); 
            }
    }           

    }

}
