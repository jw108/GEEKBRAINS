/* 
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
 */

Console.Clear();
// double Distance(double X1, double X2, double Y1, double Y2, double Z1, double Z2)
// {
//      double length = Math.Sqrt((X2 - X1)) + Math.Sqrt(Y2 - Y1) + Math.Sqrt(Z2 - Z1);
//      return Math.Round(length, 2);
// }

Console.WriteLine("Введите через пробел координаты для точки А в формате X Y Z ");
string[] A = Console.ReadLine().Split(' ');
double X1 = double.Parse(A[0]);
double Y1 = Convert.ToDouble(A[1]);
double Z1 = Convert.ToDouble(A[2]);
Console.WriteLine($"X1= {X1}");
Console.WriteLine("Введите через пробел координаты для точки B в формате X Y Z ");
string[] B = Console.ReadLine().Split(' ');
double X2 = Convert.ToDouble(B[0]);
double Y2 = Convert.ToDouble(B[1]);
double Z2 = Convert.ToDouble(B[2]);
Console.WriteLine(Y2);
double dist = Convert.ToDouble (Math.Sqrt((X2 - X1)) + Math.Sqrt(Y2 - Y1) + Math.Sqrt(Z2 - Z1));
//double dist = Convert.ToDouble(Distance);
Console.WriteLine(dist);