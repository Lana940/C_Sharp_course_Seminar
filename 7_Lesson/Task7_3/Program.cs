// Задайте двумерный массив. Найдите сумму элементов главной диагонали.Например, задан массив:  1 4 7
//      Сумма элементов главной диагонали: 1+9+2 = 12                                           5 9 2  
//                                                                                              8 4 2
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

int SumDiagonalNumbers (int [,] matrix)
{
    int rows = matrix.GetLength(0);
    int sum = 0;

    for (int i = 0; i < rows; i++)
    {
        sum += matrix[i, i];
    }
    return sum;

}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row,column, 1, 101);
PrintArray(arr_1);

Console.WriteLine(SumDiagonalNumbers(arr_1));

