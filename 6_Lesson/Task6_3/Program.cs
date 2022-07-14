// : Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci (int num)
{
    int num_1 = 0;
    int num_2 = 1;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{num_1} ");
        (num_1, num_2) = (num_2, num_1 + num_2);
    }
}
Fibonacci(10);