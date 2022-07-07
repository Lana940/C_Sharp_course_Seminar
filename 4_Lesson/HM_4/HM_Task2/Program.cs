// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int NumSum (int num)
{   int result = 0;
    while(num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result; 
}
Console.WriteLine(NumSum(452));
Console.WriteLine(NumSum(82));
Console.WriteLine(NumSum(9012));