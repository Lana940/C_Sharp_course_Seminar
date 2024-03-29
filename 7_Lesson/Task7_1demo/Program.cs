﻿/// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();  // строка заполнена пробел
    }
    Console.WriteLine();
}

int [,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int [row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to); 
        }
    }
    return arr;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row,column,1,100);
PrintArray(arr_1);






