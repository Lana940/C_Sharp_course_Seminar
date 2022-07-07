// : Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5 

int NumberDigitsCount (int num)
{
  string result = num.ToString(); 
  return result.Length;
}

Console.WriteLine(NumberDigitsCount(456));
Console.WriteLine(NumberDigitsCount(455446));
Console.WriteLine(NumberDigitsCount(453453456));
