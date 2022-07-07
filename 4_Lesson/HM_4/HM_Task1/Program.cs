// // : Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. 3, 5 -> 243 (3⁵)  2, 4 -> 16


int MultDegree(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;

    }
    return result;

}

Console.WriteLine(MultDegree(3, 5));
Console.WriteLine(MultDegree(2, 4));
Console.WriteLine(MultDegree(5, 6));

