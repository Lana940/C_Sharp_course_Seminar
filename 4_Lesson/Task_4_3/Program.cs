// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int MultOfNums(int num)
{
    int all_mult = 1;
    for(int i = 1; i <= num; i++)
    {
        all_mult *= i;
    }
    return all_mult;
}
Console.WriteLine(MultOfNums(5));
Console.WriteLine(MultOfNums(4));
Console.WriteLine(MultOfNums(8));