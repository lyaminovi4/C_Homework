// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine()!);
if (number < 100)
Console.WriteLine("Третьей цифры нет");
else
{
    while(number >= 1000)
    {
        number = number/10;
    }
    int res = number%10;
    Console.WriteLine($"У числа {number} третья цифра: {res}");
}
