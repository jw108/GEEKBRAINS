/* 

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/
Console.Clear();
Console.WriteLine("Введите два числа через пробел: ");
string[] nums = Console.ReadLine().Split(" ");
int userNum1 = Convert.ToInt32(nums[0]);
int userNum2 = Convert.ToInt32(nums[1]);

for (int i = 1 ;i<userNum2;i++)
{   
   int res= Math.Pow(userNum1,userNum2);
   break;
}
Console.Write($"{res} ");