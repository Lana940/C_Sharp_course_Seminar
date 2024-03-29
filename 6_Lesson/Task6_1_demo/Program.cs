﻿// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int[] ReverseMassive(int[] OriginalArray)
{
    int size = OriginalArray.Length - 1;

    for (int i = 0; i < size / 2 + 1; i++)
    {
        (OriginalArray[i],OriginalArray[size - i] ) = (OriginalArray[size - i], OriginalArray[i]);
    }
     return OriginalArray;

}
int [] arr_1 = MassNums( 7, 1, 21);
Print(arr_1);
ReverseMassive(arr_1);
Print(arr_1);