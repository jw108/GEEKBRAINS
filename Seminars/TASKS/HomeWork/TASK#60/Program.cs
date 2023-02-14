﻿/*  
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();
Console.WriteLine("Данная программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов");
Console.WriteLine();
int row = 2;
int col = 2;
int num = 0;

int[] temp = new int[8];
int[,,] arr = new int[row, col, col];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
ModifyArray(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();

void FillArray(int[,,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = random.Next(10, 100); ;
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine("");
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],5}{(i, j, k)}");
            }
        }
    }
    Console.WriteLine();
}
