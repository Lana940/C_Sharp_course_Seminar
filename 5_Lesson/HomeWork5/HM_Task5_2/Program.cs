// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

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
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int OddPosAmount(int[] arr)
{
    int amount = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        amount += arr[i];

    }
    return amount;

}


int[] arr_1 = MassNums(10);
Print(arr_1);

Console.WriteLine(OddPosAmount(arr_1));



