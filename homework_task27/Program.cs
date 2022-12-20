// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int SumOfDigits(int num)
{
    int num1 = num;
    int sum = num % 10;
    while (num1 > 0)
    {
        num1 = (num1 - (num1 % 10)) / 10;
        sum = sum + (num1 % 10);
    }
    return sum;
}

int sum = SumOfDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} -> {sum}");
