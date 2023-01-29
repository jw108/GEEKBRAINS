/* 
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
 */

int[] array = new int[5];
FillArray(array);
Console.Write("массив ");
PrintArray(array);
Console.Write("\nВведите число, которое нужно найти: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckNumberAndNumberModule(array, number);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-4, 11);
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

void CheckNumberAndNumberModule(int[] array, int number)
{
    if (array.Contains(number) || array.Contains(number * -1)) Console.Write("Да");
    else Console.Write("Нет");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     if (number == array[i] || number * -1 == array[i])
    //     {
    //         Console.Write("Да");
    //         return;
    //     }
    // }
    // Console.Write("Нет");
}
/*
Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write("Введите число, которое надо найти: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0) num *= -1;
string otv = FillArray(array, num);
Console.WriteLine(otv);

string FillArray(int[] arr, int num)
{
    string a = "нет";
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
        Console.Write($"{arr[i]}, ");
        if (arr[i]<0) arr[i] *= -1;
        if (arr[i]==num) a = "да";
    }
    Console.WriteLine("\b\b ");
    return a;
}
*/
// Console.WriteLine($"[{string.Join(", ", array)}]"); для красоты вывода
