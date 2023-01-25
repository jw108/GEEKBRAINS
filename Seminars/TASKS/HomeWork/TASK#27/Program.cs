/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int[] FillArray()
// {
//     for (int i=0; i <= Count; i++)
//     {

//     }
// }


Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
//int[] array = int.Parse(num);
//Console.WriteLine(array);

int[] toIntegerArray (int number)
{
    int a = number;
    List<int> l = new List<int>();
    while(a > 0)
    {
            l.Add(a % 10);
            a = a / 10; 
    }
    return l.ToArray();
}
toIntegerArray();