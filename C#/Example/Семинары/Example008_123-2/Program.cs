
// Найти вторую цифру трёх значного числа.

//value = 123

//value div  100 = 1
//       /
//неполное частное

//value mod  100 = 23
//        %
//остаток от деления

//value div  10 = 12
//неполное частное

//value mod  10 = 1
//остаток от деления

//value div  10

//(value div  100) div  10

//(value div  10) value mod  10

// AND = &&

int value;

value = 367;

if (value > 99 && value < 1000 )
{
    int res;
    res = (value / 10) % 10;
Console.WriteLine(res);
}

else
{
Console.WriteLine("Error");
}
//Console.WriteLine((value % 100) / 10);
//System.Console.WriteLine((value / 10) % 10);