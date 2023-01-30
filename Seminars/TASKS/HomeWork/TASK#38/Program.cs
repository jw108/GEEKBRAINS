/* 
Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.Clear();
int[] array = new int[8];
FillArray();
PrintArray(array);

void FillArray()
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 100);
}

void PrintArray(int[] arg)
{
    Console.Write("[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + " ");
    }
    Console.Write("\b ] --> ");
    Console.WriteLine();
}

