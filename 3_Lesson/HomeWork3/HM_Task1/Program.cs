// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палиндромом. 14212 -> нет  23432 -> да

Console.Write("Put your number: ");
string number = Console.ReadLine();

void SameNumbers(string number)
{
  if (number[0] == number[4] || number[1] == number[3])
  {
    Console.WriteLine($" The {number} is a palindrome.");
  }
  else Console.WriteLine($"The {number} - is not a palindrome.");
}

if (number.Length == 5)
{
  SameNumbers(number);
}
else Console.WriteLine($"Put the correct number");


