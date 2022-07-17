// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3               // 17 -> такого числа в массиве нет  // не получилось решить
// 8 4 2 4

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

void ShowElementPos(int[,] arr, int row, int column)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
        {
           for (int j = 0; j < column_size; j++)
            {
                  if (row > row_size && column > column_size)
                   {
                      Console.WriteLine($" takogo elementa net");
                      break;
                   }

                  else if (arr[row, column] == arr[i, j ]);
                   {
                       Console.WriteLine($" {arr[i, j]} na pozicii {row}, {column} ");
                       return;
                   }
            }
        }
}
        

// Console.WriteLine("Enter the number of rows: ");
// int row = int.Parse(Console.ReadLine());


// Console.WriteLine("Enter the number of columns: ");
// int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(3, 8, -7, 10);
PrintArray(arr_1);


ShowElementPos(arr_1, 1, 7);