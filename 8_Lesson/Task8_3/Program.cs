// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Значения элементов массива 0..9
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
//                            1 встречается 1 раз
//                            2 встречается 1 раз
//                            8 встречается 1 раз
//                            9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
//                           1 встречается 3 раза
//                           2 встречается 2 раз
//                           3 встречается 1 раз
//                           4 встречается 1 раз
//                           6 встречается 2 раза

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

string TransponMatrix(int [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if(row != column) return "no";

    for (int i = 0; i < row; i++)
    {
       for (int j = 0; j < i; j++)
       {
         (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
       }
    }
    return "yes";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 3, 11);
Print(arr_1);

Console.WriteLine(TransponMatrix(arr_1));
Print(arr_1);