/* 
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
 */
Console.Clear(); // Очистка тепрминала
int x = 7;

// Операция ветвление
if (x % 2 == 0)
    Console.WriteLine("x - четное число");
else
    Console.WriteLine("x - нечетное число");
