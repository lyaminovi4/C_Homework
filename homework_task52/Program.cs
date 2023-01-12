// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }
    return array;
}

void PrintArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ColumnSum(int[,] matrix)
{
    // int height = matrix.GetLength(0);
    // int length = matrix.GetLength(1);
    double[] result = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i< matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        result[j] = Math.Round(sum/ matrix.GetLength(0), 2);
    }
    return result;
}

// void PrintResult(double[] inArray, int[,] matrix)
// {
//     int length = matrix.GetLength(0);

//     for (int i = 0; i < length; i++)
//     {
//         Console.Write("{0:0.0} ", inArray[i] / length);
//     }
// }

int[,] matrix = GetArray(3, 4);
PrintArray(matrix);
double[] result = ColumnSum(matrix);
Console.WriteLine(String.Join("; ", result));