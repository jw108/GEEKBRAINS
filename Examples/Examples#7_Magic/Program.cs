Console.Clear(); // Очистка консоли
// Console.SetCursorPosition(10,4); // Программа которая может указать (отступ от левого края, отступ от верхнего края)
// Console.WriteLine("+");

// Определим вершины треугольника
int xa = 40 ,  ya = 1 ,
    xb = 1 ,  yb = 30 ,
    xc = 80,  yc = 30 ;
// Поставим + в точках xa , ya
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
// Поставим + в точках xb , yb
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
// Поставим + в точках xc , yc
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
// Присвоим переменной x значение точки xa, а переменной y - xb
int x = xa, y = xb;
int count = 0;
// Запускаем цикл 
while(count < 100000)
{
    int what = new Random().Next(0, 3); // Переменной what рандомно присваиваем значения  0 1 2 [0;3]
    if (what == 0)
    {
        x = (x + xa) / 2;              // Находим середину отрезка xa 
        y = (y + ya) / 2;              // Находим середину отрезка уa 
    }

    if (what == 1)
    {
        x = (x + xb) / 2;              // Находим середину отрезка xb 
        y = (y + yb) / 2;              // Находим середину отрезка yb 
    }

    if (what == 2)
    {
        x = (x + xc) / 2;               // Находим середину отрезка xc 
        y = (y + yc) / 2;               // Находим середину отрезка ус 
    }

    Console.SetCursorPosition(x, y);    //  Устанавливаем курсор в нужную позицию для помещения туда символа +
    Console.WriteLine("+");             // Помещаем символ + в ранее установленную позицию
    count = count + 1;                  // Увеличиваем счетчик на 1
}