int numberA = new Random().Next(1, 10); //  0 1 2 3..9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);

int max = numberA;

if(numberA > numberB) max = numberA;


if (numberB > numberA) max = numberB;

{
    Console.WriteLine( max );
}