/*  
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
1 1 -> 9
*/

Console.Clear();
Console.WriteLine("Данная программа показывает число лежащее в массиве по его адресу");
//Console.Write("Задайте колличество строк: ");
int row = new Random().Next(3, 6);
//Console.Write("Задайте колличество столбцов: ");
int col = new Random().Next(3, 6);
Console.WriteLine("Введите индекс строки: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс строки: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = new int[row, col];
FillArray(array);
PrintArray(array);

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
    }
    Console.WriteLine();
}

if  (row > num1 && col > num2  )
{
    var value = array.GetValue(num1, num2);
    Console.WriteLine($"По адресу:\nИндекс строки №{num1}, индекс столбеца №{num2} лежит число --> {value}");
}
else
{
    Console.WriteLine("Такого числа не существует");
    return;
}