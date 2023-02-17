/*  
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите чило m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результатом вычисления функции Аккермана чисел:\nm = {m} и n = {n} будет --> A(m,n) = {Akkerman(m,n)}");
Console.WriteLine();
int Akkerman(int n, int m)
{
    if (n == 0)return Convert.ToInt32(m + 1);
    else if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    return (Akkerman(n - 1, Akkerman(n, m - 1)));
}