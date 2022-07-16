// : Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

// Вариант решения преподавателя


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

int[,] CopyMassive(int [,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            new_arr[i,j] = arr[i,j];
        }
    }
    return new_arr;
}


int[,] arr_1 = FillArray(2,4,1,10);
PrintArray(arr_1);
int[,] arr_1_copy = CopyMassive(arr_1);
PrintArray (arr_1_copy);

int[,] arr_2 = FillArray(6,5,-1,119);
PrintArray(arr_2);
int[,] arr_2_copy = CopyMassive(arr_2);
PrintArray (arr_2_copy);
