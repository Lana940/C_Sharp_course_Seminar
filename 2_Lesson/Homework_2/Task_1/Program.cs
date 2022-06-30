//Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5  782 -> 8

int SecondNumber(int num)

{
    return num / 10 % 10;
}

Console.WriteLine(SecondNumber(976));
