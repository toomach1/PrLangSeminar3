   //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

        Console.WriteLine("Введите Х1");
        double NumX1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Y1");
        double NumY1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Z1");
        double NumZ1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите Х2");
        double NumX2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Y2");
        double NumY2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Z3");
        double NumZ2 = double.Parse(Console.ReadLine());

        double distantion = Math.Sqrt(Math.Pow(NumX2 - NumX1, 2) + Math.Pow(NumY2 - NumY1, 2) + Math.Pow(NumZ2 - NumZ1, 2));
        Console.WriteLine($"расстояние между точками = {distantion}");
    