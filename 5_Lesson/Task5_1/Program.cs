﻿// Задача 1: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)    //лучше размерность передавать методу для работы, чтоб не задавать от руки
{

    int[] arr = new int[size];   // - создаем новый целочиц массив 
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10); //- верхняя граница не включается, потому 10
    }
    return arr;
}

void PlusMinusChange(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) arr[i] = arr[i] * -1;
        else arr[i] = arr[i] * -1;
    }
    Console.WriteLine();
}

int[] arr_1 = MassNums(12);
Print(arr_1);
PlusMinusChange(arr_1);

Print(arr_1);
