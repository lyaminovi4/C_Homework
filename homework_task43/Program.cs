// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double, double) GetLineCoord(string N1, string N2)
{
    Console.Write($"Введите {N1} ");
    double coord1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите {N2} ");
    double coord2 = Convert.ToDouble(Console.ReadLine());
    return (coord1, coord2);
}
(double b1, double k1) = GetLineCoord("b1", "k1");
(double b2, double k2) = GetLineCoord("b2", "k2");
double x = (b1 - b2) / (k1 - k2) * -1;
double y = k2 * x + b2;
Console.WriteLine($"Точка пересечения двух прямых -> ({x},{y})");