// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3               // 17 -> такого числа в массиве нет  // не получилось решить
// 8 4 2 4

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string FindElement(int[,] arr, int pos_of_row, int pos_of_column)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (pos_of_row > row  || pos_of_row <= 0 ||  pos_of_column > column || pos_of_column <= 0)
        return $"{pos_of_row} {pos_of_column} -> not in the array";
    return $"arr[{pos_of_row}, {pos_of_column}] = {arr[pos_of_row - 1, pos_of_column - 1]} -> is in the array";
}

Console.Write("Enter the row position: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(3, 4, 1, 11);
Print(arr_1);

Console.WriteLine(FindElement(arr_1, first, second));

