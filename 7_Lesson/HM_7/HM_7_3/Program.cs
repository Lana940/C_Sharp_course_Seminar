// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3             // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// 8 4 2 4
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

void AverageSum(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double sumColumns;

    for (int i = 0; i < column; i++)
    {
        sumColumns = 0; // для обнуления после 1 столбца и счета на новый столбец 
        for (int j = 0; j < row; j++)  sumColumns += arr[j, i];
 
        Console.Write($"{Math.Round(sumColumns / row, 2)};  ");    
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 1, 6);
Print(arr_1);

AverageSum(arr_1);




