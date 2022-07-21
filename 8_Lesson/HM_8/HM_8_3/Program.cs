// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplicationOfMatrices(int[,] arr_1, int[,] arr_2)
{
    int length = arr_1.GetLength(1);

    int[,] newMatrix = new int[length, length];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)

            for (int k = 0; k < length; k++)
            {
                newMatrix[i, j] += arr_1[i, k] * arr_2[k, j];
            }
    }
    return newMatrix;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Первая матрица");

int[,] arr_1 = FillArray(row, column, 1, 11);
Print(arr_1);


Console.Write("Enter the number of rows: ");
int row_2 = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Вторая  матрица");

int[,] arr_2 = FillArray(row, column, 1, 11);
Print(arr_2);

Console.WriteLine("Произведение матриц");

int[,] arr_3 = MultiplicationOfMatrices(arr_1, arr_2);
Print(arr_3);

