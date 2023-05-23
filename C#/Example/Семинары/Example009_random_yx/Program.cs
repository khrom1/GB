// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
int n1 = n / 10; // 98 / 10 = 9
int n2 = n % 10; // 98 % 10 = 8
Console.WriteLine($"Число: {n}");

if (n1 > n2)
Console.WriteLine(n1);
else if (n2 > n1)
Console.WriteLine(n2);
else
Console.WriteLine("=");
