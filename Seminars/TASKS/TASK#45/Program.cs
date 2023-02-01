/* 
 Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
 */

Console.Clear();

int[] array = new int[8];
FillArray();
PrintArray(array);
Console.WriteLine();
Copy(array);
void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] arg)
{
    Console.Write("[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + " ");
    }
    Console.Write("\b ]");
}
Console.WriteLine();

void Copy(int [] arg)
{
    Console.Write("[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + " ");
    }
    Console.Write("\b ]");
}
Console.WriteLine();


/* 
Console.Write("Введите колличество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(num);
PrintArray(array);
Console.Write(" -> ");
PrintArray(CopyArray(array));

void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 11);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}
 */