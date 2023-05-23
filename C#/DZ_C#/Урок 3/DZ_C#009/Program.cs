//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53


using System;

class GFG
{

    static void dist(float x1, float y1,
                        float z1, float x2,
                        float y2, float z2)
    {
        double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                            Math.Pow(y2 - y1, 2) +
                            Math.Pow(z2 - z1, 2) *
                                    1.0), 0.5);
        Console.WriteLine("Расстояние между точками = \n" + d);
        return;
    }

   
    public static void Main()
    {
        float x1 = 7;
        float y1 = -5;
        float z1 = 0;
        float x2 = 1;
        float y2 = -1;
        float z2 = 9;

        dist(x1, y1, z1, x2, y2, z2);
    }
}
