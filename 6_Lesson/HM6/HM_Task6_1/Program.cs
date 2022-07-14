// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] FillArray(int size, int from, int to)
{

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int CountPositiveNumbers(int[] arr)
{
    int amount = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) amount += 1;
    } 
     return amount;
}  


int[] arr_1 = FillArray(7, -11, 21);
Print(arr_1);
Console.WriteLine(CountPositiveNumbers(arr_1));
