// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.Clear();
Console.Write("Задайте колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
FillArray(array);
PrintArray(array);
Console.Write(" -> ");
int sum = FindSumOnMainDiagonal(array);
Console.Write(sum);

int FindSumOnMainDiagonal(int[,] arr)
{
    int result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j) result += array[i,j];
        }
    }
    return result;
}

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5}");
        }
    }
}