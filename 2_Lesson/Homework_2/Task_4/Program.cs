// : Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekEndsFind()
{
    int num = new Random().Next(1, 8);
    Console.WriteLine(num);

    if (num > 5)
    {
        Console.WriteLine($"{num} -> Ура, Выходной!");

    }
    else
    {
        Console.WriteLine($"{num} - > Дуй на работу!");
    }

}
WeekEndsFind();

----------------------------
////решение из семинара 3
void Weekend(int num)
{
    string text = "no";
    if (num == 7 || num == 6) text = "yes"; //  || - или то или другое 
    Console.WriteLine($"{num} -> {text}");

}

Weekend(6);
Weekend(7);
Weekend(1);