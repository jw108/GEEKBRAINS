/*  
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
*/

Console.Clear();
Console.WriteLine("Данная программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов");
Console.WriteLine();
int row = 4;
int col = 5;

int[,] arr = new int[row, col];
int temp = int.MaxValue;
int index= 0;
FillArray(arr);
PrintArray(arr);
SummEachRows(arr);
Console.WriteLine();

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

void SummEachRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        if (summ < temp )
        {
            temp = summ;
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой чисел № {index+1}, её сумма равна {temp} ");
}
