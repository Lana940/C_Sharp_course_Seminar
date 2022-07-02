// : Напишите программу, которая по  заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void Quarters(int QuarterNumber)
{
    if (QuarterNumber == 1) Console.WriteLine(("x > 0, y > 0"));
    else if (QuarterNumber == 2) Console.WriteLine("x < 0, y > 0");
    else if (QuarterNumber == 3) Console.WriteLine("x < 0, y < 0");
    else if (QuarterNumber == 4) Console.WriteLine("x > 0,  y < 0");

    else Console.WriteLine("invalid data");
}

Quarters(4);
Quarters(3);
Quarters(1);
Quarters(2);