/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Console.Clear();
int[] array = new int[8];
FillArray();
PrintArray(array);
int res = FindIndexes(array);
Console.WriteLine(res);
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
    Console.Write("\b ] --> ");
}
Console.WriteLine();

int  FindIndexes(int[] array)
{   int result =0;
Console.Write("[ ");
    for (int i=1; i<array.Length;i+=2)
    {
        Console.Write(array[i] + " ");
        result = result + array[i];
    }
    Console.Write("\b ] Сумма чисел стоящих на нечетных позициях массива --> ");
    return result;
}