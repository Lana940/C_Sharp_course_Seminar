//найти макс из 3х чисел
int numberA = new Random().Next(1, 10); //  0 1 2 3..9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int numberC = new Random().Next(1, 10);
Console.WriteLine(numberC);

int max = numberA;

if(numberA > numberB) max = numberA;

     if (numberB > numberA) max = numberB;

         if (numberC > numberB) max = numberC;

{
    Console.WriteLine( max );
}
