/*  
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.Write("Введите чило M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write(PrintNubers(M,N));

string PrintNubers(int start, int end)
{
    if (start == end) return Convert.ToString(start);
    return (start + " " + PrintNubers(start + 1, end));
}