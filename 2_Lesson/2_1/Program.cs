//Напишите прогу, которая принимает на вход трехзначное число 
//и на выходе показывает последнюю цифру этого числа 456 -> 6, 782 -> 2 итд

int TakeNum(int num)
{
    return num % 10;
}
Console.WriteLine(TakeNum(678));
Console.WriteLine(TakeNum(6155558));