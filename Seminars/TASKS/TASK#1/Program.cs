// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите квадрат числа: ");
int exp = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число для проверки: ");
int number = int.Parse(Console.ReadLine());
int result = exp / number;
if (result == number){
    Console.WriteLine("Введеное число является квадратом " + number);
}
else {
    Console.WriteLine("Введеное число не является квадратом " + number);
}