/*  
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int row = new Random().Next(3, 6);
int col = new Random().Next(3, 6);
int[,] array = new int[row, row];

FillArray(array);
PrintArray(array);
Console.WriteLine();

AverOfAllCol(array, row);

Console.WriteLine();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
    }
}

void AverOfAllCol(int[,] arr, int row)
{
    double[] avr = new double[row];
    Console.Write($"Среднее арифметическое каждого столбца:[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp += (arr[j, i]);
            avr[i] = temp/row;
        }
        Console.Write($" {avr[i]+ ";"}");
    }Console.Write(" ]");
}
