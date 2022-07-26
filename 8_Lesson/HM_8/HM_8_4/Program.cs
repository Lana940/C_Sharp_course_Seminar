// Задача 4. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] MinElement(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int minElement = arr[0, 0];
    int[] indexes = new int[2]; //фиксируем в отдельный одномерный массив i, j(координаты) елемнета


       for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (minElement > arr[i, j])
            {
                minElement = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]); //выводим мин елемент
    return indexes;
}

void WithoutRowColumn(int[,] arr, int[] m_indexes)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (m_indexes[0] == i || m_indexes[1] == j) continue; // переходи на след елемент
            else Console.Write($"{arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, -5, 10);
Print(arr_1);

int[] mass = MinElement(arr_1);
WithoutRowColumn(arr_1, mass);

