﻿// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void FindIntersection(double b1, double b2, double k1, double k2)

{
    double x =  (b2 - b1) /( k1 - k2); // k1*x + b1 = k2*x + b2  -> x(k1 -k2) = b2 -b1 -> x = (b2 - b1) / (k1 -k2)
    double y = k1*x + b1;
    

    Console.WriteLine($"{x}, {y} ");
}

FindIntersection(2, 4, 5, 9);
FindIntersection(2, 8, 3, 7);
FindIntersection(3, 5, 7, 1);

