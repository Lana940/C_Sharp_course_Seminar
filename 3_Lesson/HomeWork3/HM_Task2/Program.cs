// : Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

double XYDistance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); //  AB = √(xb - xa)2 + (yb - ya)2 + (zb -za)2
}

XYDistance(3,6,2,1,4,8);
Console.WriteLine(XYDistance(3,6,2,1,4,8));