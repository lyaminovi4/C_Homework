// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i=0; i < rows; i++)
    {
       for (int j=0; j < columns; j++) 
       {
            array[i, j] = new Random().Next(1, 10);
       }
    }   
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    result[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }
        }
    }
    return result;
}

int[,] matrixA = GetArray(2,2);
Console.WriteLine($"Первая матрица:");
PrintArray(matrixA);
int[,] matrixB = GetArray(2,2);
Console.WriteLine($"Вторая матрица:");
PrintArray(matrixB);
int[,] matrixC = MatrixMult(matrixA,matrixB);
Console.WriteLine($"Произведение матриц:");
PrintArray(matrixC);