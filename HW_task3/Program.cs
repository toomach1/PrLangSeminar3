// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Кубы чисел от 1 до {Num}");
for (int i = 1; i < Num; i++)
{
    
    System.Console.Write($"{Math.Pow(i,3)}, ");
}

System.Console.WriteLine(Math.Pow(Num,3));