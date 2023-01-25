/* 
Задача №20.
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
 */
double Distance(double x1, double y1, double x2, double y2)
{
 double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
 return Math.Round(length, 3);
}
Console.Clear();
Console.Write("Ведите десятичное число X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите десятичное число Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите десятичное число X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите десятичное число Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double dist = Distance(x1,y1,x2,y2);
Console.WriteLine(dist);