// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    Random rand = new Random();
    while (index < length)
    {
       arr[index] = rand.Next(-10,10);
       index++;
    }
}
void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + "  ");
    }
    System.Console.WriteLine();
}
int Summ(int[] arr)
{
    int sum = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

int [] arr = new int[10];

FillArray(arr);
PrintArray(arr);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна " + Summ (arr));