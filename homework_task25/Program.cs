// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральную степень: ");
int n2 = int.Parse(Console.ReadLine()!);
int Exponentiation(int n1, int n2)
{
    int res = 1;
    while (n2 != 0)
    {
        res = res * n1;
        n2--;
    }
    return res;
}
int res = Exponentiation(n1, n2);
Console.WriteLine($"Число {n1} в степени {n2} = {res}");