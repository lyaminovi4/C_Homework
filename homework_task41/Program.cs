// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел: ");
int m = int.Parse(Console.ReadLine()!);
int[] OurArray = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    OurArray[i] = int.Parse(Console.ReadLine()!);
  }
}

int Compare(int[] OurArray)
{
  int count = 0;
  for (int i = 0; i < OurArray.Length; i++)
  {
    if(OurArray[i] > 0 ) 
    count++; 
  }
  return count;
}
InputNumbers(m);

Console.WriteLine($"Введено чисел больше нуля: {Compare(OurArray)} ");