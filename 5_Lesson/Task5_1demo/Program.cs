// // Задача 1: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)    //лучше размерность передавать методу для работы, чтоб не задавать от руки
{

    int[] arr = new int[size];   // - создаем новый целочиц массив 
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10); //- верхняя граница не включается, потому 10
    }
    return arr;
}

void SumMaxMin(int[] arr)
{
    int sum_max, sum_min;
    sum_max = sum_min = 0;  //так можно писать, тк обе = 0 и ранее уже обьявлены int(т.е целочисленными)

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) sum_max += arr[i];
        else sum_min += arr[i];
    }
    Console.WriteLine($"sum max : {sum_max}, sum min : {sum_min}");
}

int[] arr_1 = MassNums(12);
Print(arr_1);
SumMaxMin(arr_1);