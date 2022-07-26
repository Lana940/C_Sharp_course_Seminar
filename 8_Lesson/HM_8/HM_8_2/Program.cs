// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив: 1 4 7 2
//                         5 9 2 3
//                         8 4 2 4
//                         5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void RowWithMinSum(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int rowCount = 0;
    int minSum = 10000;
    
        for (int i = 0; i < row; i++)
        {
            int sumOfRow = 0;
            for (int j = 0; j < column; j++) sumOfRow += arr[i, j];
            if (sumOfRow < minSum)
            {
                if (minSum == sumOfRow)
                {
                    Console.WriteLine($"Row {rowCount} with min sum {minSum}" );
                }
                 minSum = sumOfRow;
                 rowCount ++;
            }   

        }
     Console.WriteLine($" Row {rowCount} with min sum {minSum} ");

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 1, 7);
Print(arr_1);

RowWithMinSum(arr_1);
Print(arr_1);
