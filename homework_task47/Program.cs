//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

void GetArray(double[,] array)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    }
  }
}

void PrintArray (double[,] array)
{
for (int i = 0; i < rows; i++)
  {
      for (int j = 0; j < columns; j++)
      {
        double Number = Math.Round(array[i, j], 1);
        Console.Write(Number + "  ");
      }
      Console.WriteLine();
  }
}

double[,] array = new double[rows, columns];
GetArray(array);
PrintArray(array);
Console.WriteLine();