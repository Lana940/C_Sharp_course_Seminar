// : Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)   1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8

// Вариант преподавателя:

void Print( int [] arr)
{
    int size = arr.Length;
    for (int i = 0;  i < size; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

int [] EightMassive()    //   - int [] - возвращает нам массив
{
    int size = 8;
    int [] arr = new int [size];   // - создаем новый целочиц массив из 8 позиций
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
    return arr;
}

int [] arr_1 = EightMassive();    // для сохранения массива, поскольку сейчас он только внутри метода
Print(arr_1);
int [] arr_2 = EightMassive();
Print(arr_2); 
int [] arr_3 = EightMassive();
Print(arr_3); 