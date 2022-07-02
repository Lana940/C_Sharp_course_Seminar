// программу которая на входе принимает число N, а на выходе дает все четные числа от 1 до N

int N = int.Parse(Console.ReadLine());
int M = 2;

while (M < N + 1)
{
Console.WriteLine(M);
M += 2;
}