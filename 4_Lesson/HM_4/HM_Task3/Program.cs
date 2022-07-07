// : Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)   1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8

void FillArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void PrintArray()
{
    int[] arr = { };
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

FillArray();
PrintArray();

