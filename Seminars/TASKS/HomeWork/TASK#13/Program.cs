﻿/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
 */

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Введите число больше нуля");
}
else if (num > 99)
{
    Console.WriteLine((num %10) %10 );
}
else Console.WriteLine("Третьей цифры нет");