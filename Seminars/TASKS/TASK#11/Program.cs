/* 
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

 */
Console.Clear();
int num = new Random().Next(100,1000);
// int num = (new Random().Next(10, 100) * 10);
Console.WriteLine(num);
int firstNum = num /100;
int firdNum = num %10;
Console.WriteLine ($"{firstNum}{firdNum}");