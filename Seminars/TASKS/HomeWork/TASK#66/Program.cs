/*  
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите чило M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());


Console.Write($"Сумма чисел от N = {M} до М = {N} --> {PrintNumbers(M,N)}");
Console.Write("\b");
Console.WriteLine();
int PrintNumbers(int start, int end)
{
    if (start == end) return Convert.ToInt32(start);
    return (start + PrintNumbers(start+1,end));
}
