// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// То как пыталась сделать я :
//// void ThirdDigit( int N)
//{
//    while(N > 999)
//   {
//      Console.WriteLine($"{N / 10} -> {N % 10}");
//   } 
//
//   if(N < 99)
// {
//       Console.WriteLine("3rd digit not exist");
// }
//  return;
//}    
//Console.WriteLine(ThirdDigit(1254));

// как правильно:

void ThirdDigit(int N)
{
    Console.Write($"{N} ->");
    if (N < 99)
    {
        Console.WriteLine("No 3rd digit in this number");
        return;
    }

    while (N > 999) N = N / 10;
    Console.WriteLine(N % 10);
}

ThirdDigit(int.Parse(Console.ReadLine()));