/* 
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
 */
Console.Clear();
int row = new Random().Next(5,7);

int[,] array = new int[row, row];
FillArray(array);
PrintArray(array);
Console.WriteLine();
if (array.GetLength(0) != array.GetLength(1) ) 
{
    Console.WriteLine("Не возможное условие выполнения программы");
    return;
} 
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
    for (int row = 0; row < arr.GetLength(0); row++)
    {
      for (int col = row+1; col < arr.GetLength(1); col++)
      {
        int temp = arr[row,col];
        arr[row,col] = arr[col,row];
        arr[col,row] = temp;
      }
    }
}