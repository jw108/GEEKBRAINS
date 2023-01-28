/* 
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
 */

int[] arr = new int[new Random().Next(3, 12)];
int index = (arr.Length % 2 == 0) ? (arr.Length / 2) : (arr.Length / 2 + 1);
int[] arrM = new int[index];

Console.Write($"[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($"{arr[i]} ");
}
Console.Write("] -> ");

for (int i = 0; i < arrM.Length; i++)
{
    if(i == (arr.Length - i - 1)) arrM[i] = arr[i];
    else    arrM[i] = arr[i] * arr[arr.Length - i - 1];
    Console.Write($"{arrM[i]} ");
}