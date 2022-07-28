// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenSequence(int M, int N)
{
    if (N < M) return;
    if (M % 2 != 0) M++;
    EvenSequence(M + 2, N);
    Console.Write($"{M},  ");
    

}
EvenSequence(4, 8);
Console.WriteLine();
EvenSequence(2, 10);
Console.WriteLine();
EvenSequence(1, 5);

// void EvenSequence(int M, int N)   - работает если задать изначально четные М и N
// {
//     if (N < M) return;
//     if (M % 2 != 0) M++;
//     EvenSequence(M, N -2);
//     Console.Write($"{N},  ");