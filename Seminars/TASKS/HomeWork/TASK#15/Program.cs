﻿/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
 */
Console.Clear();
Console.WriteLine("Введите число дня недели для проверки будний или выходной день: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = { "Mondey", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
if (num < 1 || num > 7) Console.WriteLine("Введите корректное число дня недели от 1 до 7");
else if (num == 6 || num == 7) Console.WriteLine($"Число {num} --> является выходным днем {array[num-1]}");
else if (num >= 1) 
{
    num--; 
    Console.WriteLine($"Введеное число это будний день {array[num]}");
}