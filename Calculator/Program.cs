
Console.WriteLine("Какую операцию выполнить?");
Console.WriteLine("1.Сложить 2 числа");
Console.WriteLine("2.Вычесть первое из второго");
Console.WriteLine("3.Перемножить два числа");
Console.WriteLine("4.Разделить первое на второе");
Console.WriteLine("5.Возвести в степень N первое число");
Console.WriteLine("6.Найти квадратный корень из числа");
Console.WriteLine("7.Найти 1 процент от числа");
Console.WriteLine("8.Найти факториал из числа");
Console.WriteLine("9.Выйти из программы");

int count = Convert.ToInt32(Console.ReadLine());
while (count != 9)
{
    if (count == 1)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат " + (a + b));
   
    }
   if (count == 2)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат " + (a - b));

    }
   if (count == 3)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат " + (a * b));

    }
   if (count == 4)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат " + (a / b));

    }
    if (count == 5)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        double N = 0;
        Console.WriteLine("Результат " + (Math.Pow(a,N)));

    }
    if (count == 6)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("Результат " + Math.Sqrt(a));

    }
    if (count == 7)
    {

        Console.WriteLine("Введите первое число");
        float a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат " + (a/100));

    }
    if (count == 8)
    {

        Console.WriteLine("Введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        for (int i = 1; i <= a; i++)
        {
            c = c * i; 
        }
        Console.WriteLine("Результат " + c);

    }
    Console.WriteLine("Какую операцию выполнить?");
    int count2 = Convert.ToInt32(Console.ReadLine());
    count = count2;
    
}