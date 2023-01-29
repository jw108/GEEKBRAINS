/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
* Напишите программу которая задает массив из N элементов в заданном пользовательском диапазоне и выводит их на экран
*/

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
Console.Write(String.Join(", ", array));
Console.Write(" -> ");
PrintArray(array);
Console.WriteLine();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 50);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" ]");
}
