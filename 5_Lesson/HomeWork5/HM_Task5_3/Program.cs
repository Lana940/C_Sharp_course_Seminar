// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3, 7, 22, 2, 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{

    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble();
    }
    return arr;
}

void MaxMinDifference(double[] arr)
{
    double min_1 = arr[0];
    double max_1 = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
       if(min_1 > arr[i])
       {
        arr[i] = min_1;
       }
       else if(max_1 < arr[i])
       {
        max_1 = arr[i];
       }
    }
    Console.WriteLine($"Min {min_1}, Max {max_1} ");
    Console.WriteLine($"Difference {max_1} - {min_1} -> {max_1 - min_1} ");

}


double[] arr_1 = MassNums(5);
Print(arr_1);
MaxMinDifference(arr_1);



