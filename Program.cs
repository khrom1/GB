//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите элементы через пробел");
        string array = Console.ReadLine() ;

        
        string[] workArray = array.Split();
        string[]  resultArray = workArray.Where(array => array.Length < 4).ToArray();

        Console.WriteLine("Массив из строк, длина которых меньше либо равна 3:  ");
        Console.WriteLine(String.Join(" ",  resultArray));




    }
}
