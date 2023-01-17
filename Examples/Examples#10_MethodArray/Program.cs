
Console.Clear();
int[] array = { 1, 12, 4, 16, 18, 19, 30, 23, 43 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n) 
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // для того чтобы прекращал поиск числа в случае повтора чисел в массиве
    }
index++;
}