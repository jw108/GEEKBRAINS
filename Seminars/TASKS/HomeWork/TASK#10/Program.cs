/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 999)
{
    int firdNum = num % 100;
    int secondNum = firdNum / 10;
    Console.WriteLine($"Вторая цифра введенного числа --> {secondNum}");
}
else Console.WriteLine("Увы ! Вы ввели не трехзначное число");