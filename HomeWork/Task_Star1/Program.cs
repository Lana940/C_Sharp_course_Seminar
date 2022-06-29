// Модуль числа           // другой вариант bez else:

int a = int.Parse(Console.ReadLine());      int a = int.Parse(Console.ReadLine());      

if (a < 0)                                   if (a < 0)
                                             {
                                                a = -a;
                                             }
{
    Console.WriteLine(a = a * -1);           Console.Write(a);
}
else
{
    Console.WriteLine(a = a);
}