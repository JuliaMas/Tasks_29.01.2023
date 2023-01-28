//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void FillArray(int[] array)
{
    int length = array.Length;
    int i = 0;
    while(i < length)
    {
        array[i] = new Random().Next(10,100);
        i++;
    }
}
void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write(item + "  ");
    }
    Console.WriteLine();
}

int Diff(int[] array)
{
    int max = array[0];
    int min = array[0];
    //int diff = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }

    }
    //Console.WriteLine("максимальное значение " + max);
    //Console.WriteLine("минимальное значение " + min);   
    int diff = max - min;
    return diff;
}


int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine("разница между максимальним и минимальным элементом массива равна " + Diff(array));