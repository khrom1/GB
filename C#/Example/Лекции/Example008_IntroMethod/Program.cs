//Создание метода MAX из трёх чисел
int Max(int arg1,int arg2,int arg3)
{
    int resault = arg1;
    if(arg2> resault) resault = arg2;
    if(arg3> resault) resault = arg3;
    return resault;
}
//Конец метода Max


int a1 = 15;
int b1 = 34;
int c1 = 86;
int a2 = 45;
int b2 = 3423;
int c2 = 97;
int a3 = 22;
int b3 = 99;
int c3 = 56;


// Вариант 1 без метода MAX 
//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;


// Вариант 2 c методом MAX без функционального программирования
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

// Вариант 3 c методом MAX в одну строчку
//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// Вариант 4 c методом MAX итог

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);
