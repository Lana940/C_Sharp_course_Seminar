﻿// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void ValuesSet(int num)
{
    if (num == 0) return; //return tut kak break, zavershaet deystvie i nichego ne vozvrashaet
    ValuesSet(num - 1);
    Console.Write($"{num}, ");
}
ValuesSet(5);