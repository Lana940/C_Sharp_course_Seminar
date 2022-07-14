// : Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}

void CopyArray(int [,] matr)
{
    Console.WriteLine($"{matr} ");
}
Console.WriteLine();

int[,] matrix = new int[2, 4];
PrintArray(matrix);
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

CopyArray(matrix);
PrintArray(matrix);