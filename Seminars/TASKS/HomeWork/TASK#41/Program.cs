/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
 */

Console.Clear();
Console.WriteLine("Введите числа через пробел для подсчета введенных положительных чисел: ");
string[] nums = Console.ReadLine().Split(" ");
int[] ints = Array.ConvertAll(nums, int.Parse); // Преобразование строкового массива в массив int
//Convert(nums);
int res = Count(ints);
Console.WriteLine(res);


int Count(int[] arg)
{
    int count = 0;

    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] > 0) count++;
    }
    return count;
}
