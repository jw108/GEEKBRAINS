﻿/* 
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */
Console.Clear();
int CountOfNumber(int number) // Пользователь вводит требуемое число
{
    int count =0;    // Создали счетчик подсчета кол-ва делений введенного числа
    while(number >0) // Цикл работает пока number больше нуля
    {
        number /=10; // получаем остаток от деления пока namber не станет нулем
        count++;    // подсчитываем кол-во раз деления введенного числа 
    }
    return count;
}


Console.Write("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Счетчик количества символов в числе {num} составляет {CountOfNumber(num)} ");