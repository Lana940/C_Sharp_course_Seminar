// : Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



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

void FindNumber(int[] arr, int number)
{
    string flag = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if (number == arr[i])
        {
            flag = "Yes";
            break;
        }
    }
    Console.WriteLine($"{number}, {flag}");
}

int[] arr_1 = MassNums(12);
Print(arr_1);
FindNumber(arr_1, 4);


