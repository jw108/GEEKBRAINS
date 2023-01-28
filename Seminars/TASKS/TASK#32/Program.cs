/* 
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
 */

int[] arr = new int[12];
int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-1,2);
    Console.Write($"{arr[i]}, ");
    if (arr[i] < 0) 
    {
        arr[i] *= -1; 
        sumNeg += arr[i];
    }
    else 
    {
        arr[i] *= -1;
        sumPos += arr[i];
    }
}
Console.WriteLine("\b\b ");

// Console.WriteLine("Сумма положительных чисел в массиве - {0}", sumPos);
// Console.WriteLine("Сумма отрицательных чисел в массиве - {0}", sumNeg);

/* 
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = new int[4];

FillPrintArray(array);
Console.Write(" -> ");
ReverseElement(array);

void ReverseElement(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    Console.Write("]\n");
}

void FillPrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-4, 11);
        Console.Write(array[i] + " ");
    }
    Console.Write(" ]");
}
 */