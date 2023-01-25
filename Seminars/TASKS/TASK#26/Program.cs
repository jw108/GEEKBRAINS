/* 
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */
Console.Clear();
int CountOfNumber(int number)
{
    int count =0;
    while(number >0)
    {
        number /=10;
        count++;
    }
    return count;
}


Console.Write("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Счетчик количества символов в числе {num} составляет {CountOfNumber(num)} ");