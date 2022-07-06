// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палиндромом. 14212 -> нет  23432 -> да
//Общее решение без ограничения в индексах
void Palindrome (int n)   //Method
{
  int i = 0;
  string num = n.ToString();
  int size = num.Length - 1;
  string flag = "yes";

  while (i < size/2)
  {
    if (num[i] != num[size - i]) // !=  - ne ravno, esli 1 i posledniy element ne sovpadaet, srazu zhe
    {
      flag = "no";               // vyhodim iz proverki i wywodim no
      break;
    }
    i += 1;
  }
  Console.WriteLine($"{n} -> {flag}");  
}

Palindrome(14212);
Palindrome(23432);
Palindrome(12821);
Palindrome(1248421);
Palindrome(12488421);


