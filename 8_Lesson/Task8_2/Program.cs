<<<<<<< HEAD
﻿// Задача 2: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


=======
﻿// Задача 2: Задайте двумерный массив. Напишите программу,  которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.
>>>>>>> 8_Lesson
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
<<<<<<< HEAD
       for (int j = 0; j < i; j++)
       {
         (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
=======
       for (int j = 0; j < i; j++) // если сделать j<column, то матрица перевернется снова сама в себя и 
                                   // i == j не должно быть, тк на етих позициях они не меняются (диагональ остается на месте)
       {
         (arr[i, j], arr[ j, i]) = (arr[j, i], arr [i, j]);
>>>>>>> 8_Lesson
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
<<<<<<< HEAD
Print(arr_1);
=======
Print(arr_1);
>>>>>>> 8_Lesson
