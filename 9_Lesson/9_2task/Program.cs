// Задача 2: Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write ("Put number M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write ("Put number N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Sequence (int M, int N)
{
    if ( N < M) return; 
    Sequence(M, N -1 );
    Console.Write($"{N}, ");
}
Sequence(M, N);