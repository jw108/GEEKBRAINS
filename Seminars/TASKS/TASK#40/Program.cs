/* 
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.Clear();
Console.WriteLine("Введите сторону А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сторону C");
int c = int.Parse(Console.ReadLine());

CheckTtiangle(a,b,c);
void CheckTtiangle(int a, int b, int c)
{ 
    if ((a<b+c) && (b<a+c) && (c<b+a) )Console.WriteLine("Условие верное");
    else Console.WriteLine("Условие не верно");
}

