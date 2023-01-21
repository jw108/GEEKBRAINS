/* 
Задача №18
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
 */

Console.Write("Ведите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
    {
        Console.WriteLine("X = от 0 до 10, Y = от 0 до 10");
        break;
    }

    case 2:
    {
        Console.WriteLine("X = от 0 до 10 , Y= от 0 до -10");
        break;
    }

    case 3:
    {
        Console.WriteLine("X = от 0 до -10 , Y= от 0 до -10");
        break;
    }
    case 4:
    {
        Console.WriteLine("X = от 0 до -10 , Y= от 0 до 10");
        break;
    }
    
    default:
    {
        Console.WriteLine("Нет данных");
        break;
    }
}