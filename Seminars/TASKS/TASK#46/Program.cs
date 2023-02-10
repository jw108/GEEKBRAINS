// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Задайте колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine("");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 11);
        Console.Write($"{array[i, j], 3}");
    }
}