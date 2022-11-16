//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

System.Console.WriteLine("Введите Х1");
double NumX1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y1");
double NumY1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите Х2");
double NumX2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y2");
double NumY2 = double.Parse(Console.ReadLine());

double distantion = Math.Sqrt(Math.Pow((NumX2-NumX1),2) + Math.Pow((NumY2-NumY1),2));
System.Console.WriteLine(distantion);