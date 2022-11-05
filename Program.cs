 double a, b;
        Console.Write("Введите первое число: ");
        a = Double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Double.Parse(Console.ReadLine());
        if (a > b)
            Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
        else Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);

