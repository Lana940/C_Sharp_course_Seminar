// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void DecimalToBinary(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result; //result += num % 2;
        num = num / 2;
    }
    Console.WriteLine(result);

}
DecimalToBinary(42);