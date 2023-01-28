// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr [index] = new Random().Next(100,999);
        index++;
    }
}
void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}


int CountNumbers(int[] arr)
{
    //int n = collection.Length;
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int [] arr = new int[10];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве равно " + CountNumbers(arr));

