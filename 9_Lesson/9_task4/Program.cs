// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int Multiplication(int A, int B)
{
    if (B == 0) return 1; //все в 0 степени == 1
    return Multiplication(A, B - 1) * A;

}
Console.WriteLine(Multiplication(3 , 5));
Console.WriteLine(Multiplication( 2, 3));
