// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление. 34, 5 -> не кратно, остаток 4 , 16, 4 -> кратно

using System;

namespace _2_2
{
    class Program
    {
        static int CheckinValues(in int val1, in int val2)  // in - указатель на тот кусочек памяти, что задейстовван в  int value1 = int.Parse(Console.ReadLine());/ int value2 = int.Parse(Console.ReadLine());,  сейчас не обязателен
        {
            return  (val1 % val2);
        }

        static void Main(string[] args)                     // 
        {
            Console.Write("Введите первое число");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("введите второе число");
            int value2 = int.Parse(Console.ReadLine());

            int val =  CheckinValues(in value1, in value2);   // in value2
            if (val == 0)  
            {
                Console.WriteLine("Числа кратные");
            }
            else
            {
                Console.WriteLine($"Остаток от деления {val}");
            }

        }
            


    }
}
