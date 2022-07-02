// : Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21   Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
// AB = √(xb - xa)2 + (yb - ya)2

double XYDistance(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //  AB = √(xb - xa)2 + (yb - ya)2
}

XYDistance(3,6,2,1);
Console.WriteLine(XYDistance(3,6,9,4));