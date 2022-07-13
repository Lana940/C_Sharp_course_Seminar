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
    Random n_new = new Random ();  // создали обьект класса рендом

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10), 2); //math.round ....2 округляет до 2 цифр после , 10 - диапазон, можно менять
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
    Console.WriteLine($"Difference {max_1} - {min_1} = {Math.Round(max_1 - min_1, 2)}");

}


double[] arr_1 = MassNums(5);
Print(arr_1);
MaxMinDifference(arr_1);



