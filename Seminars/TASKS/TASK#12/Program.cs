/* 
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
 */

Console.Clear(); // Очистка тепрминала
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int b = int.Parse(Console.ReadLine());

if (a%b == 0)
{
    Console.WriteLine("Первое число является кратным");
}
else 
{
    Console.WriteLine("Остаток от деления " + a % b);
}

// string[] arr =  Console.ReadLine().Split(' ');

// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);