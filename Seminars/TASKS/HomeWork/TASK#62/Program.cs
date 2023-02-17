/*  
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Console.Clear();
// Console.WriteLine("Данная программа заполнит спирально массив 4 на 4");
// Console.WriteLine();
// int row = 4;
// int col = 4;

// int[,] arr = new int[row, col];

// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();

// void FillArray(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(1, 17);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.WriteLine("");
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],4}");
//         }
//     }
//     Console.WriteLine();
// }

Console.Clear();
Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

int row = 4;
int col = 4;
int[,] array = new int[row, col];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= row*col)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)j--;
  else i--;
}

PrintArray(array);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}