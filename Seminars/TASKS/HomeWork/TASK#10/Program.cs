/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */

Console.Clear();
Console.WriteLine("Введите любое число больше нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Введите число больше нуля");
}

if(num > 0)
{   
    Console.WriteLine($"Ввидете порядковый номер цифры из числа {num}");
    int num2 = Convert.ToInt32(Console.ReadLine());
    string num1 = Convert.ToString(num);
    if (num2 == 0) 
    {
        Console.WriteLine($"Да ты походу программист, порядковый номер {num2} не существует в обычной жизни, попробуй еще разок.");
    }
    else if (num2 <= num1.Length) 
    {
        num2--;
        Console.WriteLine($"Число {num1[num2]} --> порядковый номер {num2+1} --> в числе {num1}");
    }
    else Console.WriteLine($"В числе {num1} нет столько цифр");
    
}