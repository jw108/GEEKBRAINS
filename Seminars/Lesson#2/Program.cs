// Второй семинар
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
int num = new Random().Next(10, 100);
Console.WriteLine(num);
int num1 = num % 10;
int num2 = num / 10;
Console.WriteLine(num1);
Console.WriteLine(num2);

if (num1 > num2)
{
    Console.WriteLine("Наибольшая цифра числа {0} равна {1} ", num, num1);
}
else
{
    Console.WriteLine("Наименьшая цифра числа {0} равна {1} ", num, num2); // Интерполяция строк
    Console.WriteLine("Наименьшая цифра числа " + num + " равна " + num2); // Конкатенация строк
}
