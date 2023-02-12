/*  
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
//Console.Clear();
Console.WriteLine("Данная программа упорядочивает числа лежащие в строках по убыванию");

int row = new Random().Next(3, 6);
int col = new Random().Next(3, 6);
Console.WriteLine();

int[,] arr = new int[row, col];
int temp = 0;
FillArray(arr);
PrintArray(arr);
FromMaxInRows(arr);
PrintArray(arr);
void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 20);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
    }
    Console.WriteLine();
}

void FromMaxInRows(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  { 
    for (int j = 0; j < array.GetLength(1); j++)
    { 
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        { 
          int temp = array[i, k + 1];
          
          array[i, k + 1] = array[i, k];
          
          array[i, k] = temp;
          
        }
      }
    }
  }Console.WriteLine();
}
    