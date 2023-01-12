// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindRow(int[,] array)
{
    int min; 
    int sum = 0; 
    int index;
    for (int m = 0; m < array.GetLength(1); m++)
    {
        sum += array[0, m];
    }
    min = sum; 
    index = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    return index;
}

int[,] array = GetArray(4,4);
int result = FindRow(array) +1 ;
Console.WriteLine($"номер строки с наименьшей суммой элементов: {result}");