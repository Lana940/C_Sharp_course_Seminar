// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9


int SumOfNumDigits(int num)
{
    if (num == 0) return 0;
    return SumOfNumDigits(num / 10) + num % 10;

}
Console.WriteLine(SumOfNumDigits(453));
Console.WriteLine(SumOfNumDigits(45));