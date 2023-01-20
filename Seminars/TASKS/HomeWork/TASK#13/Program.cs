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
else if (num > 99 && num < 999)
{
    Console.WriteLine($"{num} ---> " + (num %10)); // Сдвигает регистр на одно положение влево 
}
else if (num > 999 && num < 9999)
{
    Console.WriteLine($"{num} ---> " + (num % 100)/10); // Сдвигает регистр на два положения влево и удаляет все что стоит справа от него
}
else if (num > 9999 && num < 99999)
{
    Console.WriteLine($"{num} ---> " + (num%1000)/100); // Сдвигает регистр на три положения влево и удаляет все что стоит справа от него
}
else Console.WriteLine($"{num} ---> Третьей цифры нет");