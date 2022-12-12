// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse (Console.ReadLine()!);
if(number > 1000 || number < 100);
{
while(number >= 1000 || number < 100)
    {
    Console.Write("Введенное число не трёхзначное: ");
    number = int.Parse (Console.ReadLine()!);
    }
}
int number1 = number/100;
int number3 = number%10;
int number2 = (number - number1 * 100 - number3)/10;
Console.WriteLine($"У числа {number} вторая цифра: {number2}");

