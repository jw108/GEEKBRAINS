// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса не чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2       
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
Console.Clear();
Console.Write("Задайте колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PowOddIndexes(array);
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

void PowOddIndexes(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0) arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5}");
        }
    }
}