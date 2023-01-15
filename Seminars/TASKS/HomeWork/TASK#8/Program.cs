/*  
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear(); // Очистка тепрминала
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int num = 1;
if (a < 0){
    Console.Write("Введите положительное число\n");
}
while (num < a+1){
    if (num %2 == 0){
        Console.WriteLine(num);
    }
    num++ ;
}
