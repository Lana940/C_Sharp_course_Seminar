// : Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//  Пример для массива из 5, а не 123 элементов. В своём решении сделайте для  123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 500);
    }
    return arr;
}

int FindNum(int[] arr)
{
    int amount = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr [i] <= 99)
        {
            amount += 1;
        }
    }
     return amount;
}

int[] arr_1 = MassNums(123);
Print(arr_1);

Console.WriteLine(FindNum(arr_1));