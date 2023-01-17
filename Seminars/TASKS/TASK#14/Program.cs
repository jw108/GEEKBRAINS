/* 
Задача 14
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
 */

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 7 == 0) && (a % 23 == 0))
{
    Console.WriteLine("Число кратно обоим числам");
}
else 
{
    Console.WriteLine("Не кратно");
}