// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

 int Read(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray (int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
  {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
        Console.Write($"{inArray[i, j]} ");
      }
      Console.WriteLine();
  }
}

void SearchElement (int[,] inArray, int SearchRows,int SearchColumns)
{
    if(SearchRows > inArray.GetLength(0) || SearchColumns > inArray.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"искомое число -> {inArray[SearchRows, SearchColumns]}");
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int rowsPos = Read("Введите номер строки: ");
int columnsPos = Read("Введите номер столбца: ");
SearchElement(array, rowsPos, columnsPos);