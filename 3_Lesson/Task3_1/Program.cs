// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0) Console.WriteLine("x = 0, y = 0 change incoming data");
    else if (x > 0 & y > 0) Console.WriteLine("I quarter");  // &  - и
    else if (x < 0 & y > 0) Console.WriteLine("II quarter");
    else if (x < 0 & y < 0) Console.WriteLine("III quarter");
    else if (x > 0 & y < 0) Console.WriteLine("IV quarter");
}

Quarters(0, 1);
Quarters(2, 1);
Quarters(-2, 1);
Quarters(-2, -1);
Quarters(2, -1);