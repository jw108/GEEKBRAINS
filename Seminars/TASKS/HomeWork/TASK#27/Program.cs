/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.WriteLine("Введите число: ");
string userNum = Console.ReadLine();

int SecondSumm(string arg2)
{
int num = Convert.ToInt32(userNum);
int num1 = num;
int temp = 0;
int res=0;
int j=10;
for (int i =0; i<userNum.Length;i++)
{
    temp = num1%10;
    res = temp + res;
    num1=num/j;
    j*=10;
}
return res;
}
int r = SecondSumm(userNum);
Console.WriteLine(r);


/*
int Summ(string arg)
{
    int temp = 0;
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        temp = Convert.ToInt32(arg[i].ToString());  // .ToString() -  Для передачи строки а не символа в ToInt32
        result = result + temp;
    }
    return result;
}

int a = Summ(userNum);
Console.WriteLine($"Результом сложения цифр в числе {userNum} будет --> {a}");
*/