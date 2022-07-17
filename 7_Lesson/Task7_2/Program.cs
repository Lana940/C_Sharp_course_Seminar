// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:  Новый массив будет выглядеть вот так: 
// 1 4 7 2                                         1 4 7 2
// 5 9 2 3                                         5 81 2 9
// 8 4 2 4                                         8 4 2 4
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
int[,] FindTwoEven(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 1; i < row; i += 2)
    {
        for (int j = 1; j < column; j += 2)
        {
            arr[i, j] *= arr[i, j];
        }
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 3, 11);
Print(arr_1);
FindTwoEven(arr_1);
Print(arr_1);
