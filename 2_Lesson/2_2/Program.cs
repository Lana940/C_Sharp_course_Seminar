// Напишите, программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа ex 78 -> 8, 12 -> 2

int MaxNumber(int num)
{

if(num % 10 > num / 10)
{
    return num % 10;
}
else
    return num / 10;
}
int SecondNum = new Random().Next(10, 100); // верхняя граница не учитывается, потому 100 а не 99,
MaxNumber(SecondNum);    
Console.WriteLine(SecondNum);                 // тк по условию 10 и 99 входят в отрезок
Console.WriteLine(MaxNumber(SecondNum));