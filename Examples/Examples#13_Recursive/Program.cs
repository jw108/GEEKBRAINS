/*  
Вложенный массив(двумерный)
Рекурсия
*/
Console.Clear();
int row = 3;                                            // Инициализация кол-ва строк
int col = 3;                                            // Инициализация кол-а столбцов


int[,] matrix = new int[row, col];                      // Инициализация пустого двумерного массива
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
void PrintArray(int[,] arr)                             // Создание функци для вывода массива в консоле
{
    for (int i = 0; i < arr.GetLength(0); i++)          // matrix.GetLenght(0) получение кол-ва строк 
    {
        for (int j = 0; j < arr.GetLength(1); j++)      // matrix.GetLenght(0) получение кол-ва столбцов
        {
            Console.Write($"{arr[i, j],3}");            // Заполнение матрицы нулями. 3 - указывает сколько пробелов будет между ячейками
        }
        Console.WriteLine();                            // Добавление пробела между строками (для красоты)
    }
}

void FillArray(int[,] matr)                             // Функция заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i++)         // matrix.GetLenght(0) получение кол-ва строк 
    {
        for (int j = 0; j < matr.GetLength(1); j++)     // matrix.GetLenght(0) получение кол-ва столбцов
        {
            matr[i, j] = new Random().Next(1, 10);      // Заполнение матрицы рандомным числом. От 1 до 10
        }
    }
}


// В первом случае мы получим
/* 
   0   0   0
   0   0   0
   0   0   0
*/
// Во втором случае получим заполненый произвольными числами 
/*  
   5   6   5
   7   1   7
   7   8   5
*/