/* 
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
 */

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

int Multiply(int lim)
{
   int mult = 1;
   for (int i = 1; i <= lim; i++) mult *=i;
   return mult;
}

Console.WriteLine($"Произведение чисел от 1 до {A} равно {Multiply(A)} ");