/* 
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
*/
Console.Clear();
int row = new Random().Next(3, 7);
int col = new Random().Next(3, 7);
int[,] array = new int[row, col];
int[,] num = new int[row - 1, col - 1];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int numRow = 0;
int numCol = 0;
int min = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            numRow = i;
            numCol = j;
        }
    }
}
Modify(array, num, numRow, numCol);
PrintArray(num);
Console.WriteLine();
void Modify(int[,] arr, int[,] arg, int numRow, int numCol)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < numRow && j < numCol)
            {
                num[i, j] = arr[i, j];
            }
            else if (i < numRow && j > numCol)
            {
                num[i, j - 1] = arr[i, j];
            }
            else if (i > numRow && j < numCol)
            {
                num[i - 1, j] = arr[i, j];
            }
            else if (i > numRow && j > numCol)
            {
                num[i - 1, j - 1] = arr[i, j];
            }
        }
    }
}

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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
    }
}







/* 
int[,] CreateArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(3, 6), random.Next(3, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 6);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] ToFindMin(int[,] array)
{
    int min = array[0, 0];
    int minIndx1 = 0;
    int minIndx2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min )
             {
                min = array[i, j];
                minIndx1 = i;
                minIndx2 = j;
             }           
        }
    int[,] arra2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)   
        for (int j = 0, t = 0; j < array.GetLength(1); j++, t++)
        {
            if (i == minIndx1) 
            {
                i++;            
            }
            if (j == minIndx2)
            {               
                j++;
            }
            if (i == array.GetLength(0) || j == array.GetLength(1)) continue;
            arra2[k, t] = array[i, j];
        }   
    return arra2;   
}

int[,] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();

int[,] arr2 = ToFindMin(arr);

PrintArray(arr2);
*/