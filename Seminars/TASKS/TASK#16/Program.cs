/*Напишите программу которая на вход принимает два числа и проверяет является одно из них квдратом другого
5,25 -> да
8,9 -> нет
*/
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || a == b*b) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("Ни одно из чисел не является квадратом другого");