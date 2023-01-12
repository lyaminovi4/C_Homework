// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i=0; i < array.GetLength(0); i++)
    {
       for (int j=0; j < array.GetLength(1); j++) 
       {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
       }
        Console.WriteLine();
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

void SortArray(int[,] array)
{
    int min = 0;
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min = array[i, j];
            int minN = j;
            for (int n = j; n < array.GetLength(1); n++)
            {
                if (min < array[i, n])
                {
                    min = array[i, n];
                    minN = n;
                }

            }
            temp = array[i, j];
            array[i, j] = min;
            array[i, minN] = temp;
        }
    }
}
int[,] array = GetArray(4,4);
Console.WriteLine();
SortArray(array);
PrintArray(array);