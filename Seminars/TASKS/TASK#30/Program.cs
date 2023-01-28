/* 
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
 */
Console.Clear();
int[] BitArray()
{
    int[] array = new int[8]; // Задаем массив в 8 индексов
    Random rand = new Random(); // Создаем переменную для массива
    for (int i = 0; i < array.Length; i++) // увеличиваем i пока она меньше кол-ва символов в массиве
    {
        array[i] = rand.Next(0, 2);       // Заполняем массив рандомными числами от 0 до 1
    }
    return array;
}
void Print(int[] arr)                   // Метод для вывода на экран результата
{
    for (int i = 0; i < arr.Length; i++) 
    {
        //Console.WriteLine($"arr[{i}] = {arr[i]}");
        Console.Write($"{arr[i]}");
    }
}
int[] a = BitArray();                   
Print(a);
Console.WriteLine();