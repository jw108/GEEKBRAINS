/* 

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/
Console.Clear();
Console.WriteLine("Введите два числа через пробел.\nПервое число возводимое в степень второго числа: ");
string[] nums = Console.ReadLine().Split(" ");
int userNum1 = Convert.ToInt32(nums[0]);
int userNum2 = Convert.ToInt32(nums[1]);

int Pow(int arg1, int arg2)
{
    int result =1 ;
    for (int i = 0; i < arg2; i++)
    {
      result = result * arg1;
    }
    return result;
}
int res = Pow(userNum1,userNum2);
Console.WriteLine(res);