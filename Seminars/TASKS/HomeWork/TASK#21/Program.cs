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
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(length, 3);
}
Console.WriteLine("Введите через пробел координаты для точки А в формате X Y Z ");
string[] A = Console.ReadLine().Split(' ');
double x1 = Convert.ToDouble(A[0]);
double y1 = Convert.ToDouble(A[1]);
double z1 = Convert.ToDouble(A[2]);

Console.WriteLine("Введите через пробел координаты для точки B в формате X Y Z ");
string[] B = Console.ReadLine().Split(' ');
double x2 = Convert.ToDouble(B[0]);
double y2 = Convert.ToDouble(B[1]);
double z2 = Convert.ToDouble(B[2]);

double dist = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(dist);