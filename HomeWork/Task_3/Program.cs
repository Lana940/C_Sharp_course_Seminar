//Напишите программу, которая на вход принимает число и выдает является ли оно четным (%2=1)
int numberA = int.Parse(Console.ReadLine());

if (numberA % 2 == 1)
{
    Console.WriteLine("odd");
}

else
{
    Console.WriteLine("even");
}
