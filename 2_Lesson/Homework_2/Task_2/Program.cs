// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void SecondDigitMiss()
{
    int num_1 = new Random().Next(100, 1000);
    Console.WriteLine(num_1);

    Console.WriteLine($"{num_1 / 100} Secong digit miss {num_1 % 10}");

}
SecondDigitMiss();
