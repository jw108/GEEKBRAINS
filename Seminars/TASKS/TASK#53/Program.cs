/* 

Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

 */
int row = new Random().Next(5,10);
int col = new Random().Next(5,10);
int[,] array = new int[row, col];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ModifyArray(array);
PrintArray(array);
Console.WriteLine();
void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
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
            Console.Write($"{arr[i, j],5}");
        }
    }
}

void ModifyArray(int [,] arr)
{ 
    for (int i = 0; i < arr.GetLength(1); i++)
    {
      int temp = arr[0,i];
      arr[0,i] = arr[arr.GetLength(0)-1,i];
      arr[arr.GetLength(0)-1,i] = temp; 
    }
}