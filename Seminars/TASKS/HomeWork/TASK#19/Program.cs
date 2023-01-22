/* 
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Через строку и int
 */

Console.Clear();
int num1 = 23432;
int num2 = 12821;
Console.WriteLine("Введите пятизначное число");
int userNum = int.Parse(Console.ReadLine());

if (userNum < 999)
{
    Console.WriteLine("Введите корректное число");
}

if (userNum > 9999)
{
    if ((userNum / 10000) == (num1 % 10)) ;

    else Console.WriteLine("Число не является палиндромным");

    if (((userNum % 100) / 10) == (num1 % 10000) / 1000)
    {
        if (((userNum % 1000) / 100) == (num1 % 1000) / 100)
        {
            Console.WriteLine("Число палиндромное");
        }
    }

}


