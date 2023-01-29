/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
PrintArray(array);
Console.Write("[ ");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.Write("\b ] --> ");
}

int ShowPositiv(int[] arg)
{
    int count = 0;
    
    for (int j = 0; j < arg.Length; j++)
    {
        if (arg[j] % 2 == 0)
        {
            Console.Write(arg[j] + " ,");
            count++;
        }
    }
    return count;
}   
int c = ShowPositiv(array);
Console.WriteLine("\b\b ]");
Console.WriteLine($"Кол-во четных чисел в массиве [{String.Join(", ", array)}] составляет --> {c}");