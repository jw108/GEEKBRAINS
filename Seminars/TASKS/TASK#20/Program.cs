/* 
Задача №20.
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
 */
Console.Clear();
Console.Write("Ведите десятичное число X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите десятичное число Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите десятичное число X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите десятичное число Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Sqrt(x2 - x1) + Math.Sqrt(y2 - y1));
Console.WriteLine();

/* 
double Distance(double xA, double yA, double xB, double yB)
{
 double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
 return Math.Round(length, 2);
}
Console.Write("Input an x-coordonate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordonate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an x-coordonate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordonate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());
double distanceBetweenAB = Distance(xA, yA, xB, yB);
Console.WriteLine($"Distance between points A and B is {distanceBetweenAB}.");
*/

/*
Console.WriteLine("Введите координаты точки 1: ");

string[] sArr = Console.ReadLine().Split(' ');
int num1 = Convert.ToInt32(sArr[0]);
int num2 = Convert.ToInt32(sArr[1]);

Console.WriteLine("Введите координаты точки 2: ");

string[] sArr2 = Console.ReadLine().Split(' ');
int num3 = Convert.ToInt32(sArr2[0]);
int num4 = Convert.ToInt32(sArr2[1]);