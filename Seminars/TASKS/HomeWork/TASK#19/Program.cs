/* 
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Через строку и int
*/

Console.Clear();
// int num1 = 23432;
// int num2 = 12821;
Console.Write("Введите пятизначное палиндромное число для проверки: ");
int userNum = int.Parse(Console.ReadLine());


if  (userNum > 9999 && userNum < 99999)
{
    if ((userNum / 10000) == (userNum % 10))
    {
        if (((userNum % 100) / 10) == (userNum % 10000) / 1000)
        {
            if (((userNum % 1000) / 100) == (userNum % 1000) / 100)
            {
                Console.WriteLine("Число палиндромное");
            }
        }
    }
    else Console.WriteLine("Число не является палиндромным");
}
else Console.WriteLine("Введите корректное число");