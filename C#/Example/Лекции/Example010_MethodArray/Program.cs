




// найти индекс элемента масства .значение которого указано в find 
//             0  1  2 3 4 5 6  7  8 
int[] array = {1,12,17,4,15,16,17,18};

int n = array.Length;
int find = 17;


int index = 0;


while (index < n)
{
    if(array[index]==find) 
{
    Console.WriteLine(index);
    break; // прерывание на случай двух одинаковых элементов в массиве
}
    index++;


}

