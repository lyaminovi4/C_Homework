// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int n = int.Parse (Console.ReadLine()!);
while (n < 10000 || n > 99999)
{
    Console.Write("Это не пятизначное число, введите заново: ");
    n = int.Parse (Console.ReadLine()!);
}
int e = n % 10;
int d = n / 10 % 10;
int b = n / 1000 % 10;
int a = n / 10000;
if (a == e)
{
    if (b == d)
    {
        Console.WriteLine($"число {n} - палиндром");
    }
    else
    {
        Console.WriteLine($"число {n} - не палиндром");
    }
}
else
{
    Console.WriteLine($"число {n} - не палиндром");
}