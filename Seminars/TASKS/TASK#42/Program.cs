﻿/* 
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.Clear();


Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string binaryNum = ToBinary(num);
Console.Write($"{num} -> ");
PrintReverseString(binaryNum);
Console.WriteLine();

string ToBinary(int num)
{
    string result = string.Empty;
    while (num != 1)
    {
        result += num % 2;
        num /= 2;
    }
    result += 1;

    return result;
}

void PrintReverseString(string str)
{
    for (int i = str.Length - 1; i >= 0; i--)
    {
        Console.Write(str[i]);
    }
}

/* 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");

int[] PrintArray(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;  
    }
    int[] array = new int[count];
    return array;
}
int[] array = PrintArray(num);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++, num /= 2)
    {
        array[i] = num % 2;
    }
}

void ReverseArray(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--) Console.Write($"{array[i]}");
}

FillArray(array);
ReverseArray(array);
 */