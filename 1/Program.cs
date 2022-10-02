Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы\r\n");

int r = 1;
Console.WriteLine("выберите операцию");
int n = Convert.ToInt32(Console.ReadLine());
while (n != 9) 
{
    Console.WriteLine("введите 1-ое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите 2-ое число");
    int b = Convert.ToInt32(Console.ReadLine());

    if (n == 1)
    {
        r = a + b;
    }
    else if (n == 2)
    {
        r = b - a;
    }
    else if (n == 3)
    {
        r = b * a;
    }
    else if (n == 4)
    {
        r = a / b;
    }
    else if (n == 5)
    {
        r = Convert.ToInt32(Math.Pow(a, 2));
    }
    else if (n == 6)
    {
        r = Convert.ToInt32(Math.Sqrt(a));
    }
    else if (n == 7)
    {
        r = a / 100;
    }
    else if (n == 8)
    {
        for (int i = a; i > 1; i--) { r = r * i; }
    }
    else
    {
        Console.WriteLine("Неизвестный оператор");
    }
    Console.WriteLine("ответ");
    Console.WriteLine(r);
    Console.WriteLine("выберите операцию");
    n = Convert.ToInt32(Console.ReadLine());
}

