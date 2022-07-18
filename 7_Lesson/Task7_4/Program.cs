// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.  Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

void ShowElementPos(int[,] arr, int a)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == a)
            {
                Console.WriteLine($" {a} na pozicii {i+1} {j+1} "); // +1 потому что нужны не индексы, а позиция елемента
                return;
            }
        }
    }
    Console.WriteLine($" takogo elementa net");
}


Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 1, 10);
PrintArray(arr_1);

Console.WriteLine("Enter the element: ");
int a = int.Parse(Console.ReadLine());
ShowElementPos(arr_1,  a);