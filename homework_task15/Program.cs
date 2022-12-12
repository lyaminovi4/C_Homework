//Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int a = int.Parse (Console.ReadLine()!);
while(a < 1 || a > 7)
    {
    Console.Write("Введите номер дня недели от 1 до 7: ");
    a = int.Parse(Console.ReadLine()!);
    }
if (a >= 1 && a <= 5)
Console.WriteLine("Это будний день");
else 
Console.WriteLine("Это выходной день");