// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

System.Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Квадраты чисел от 1 до {Num}");
for (int i = 1; i <= Num; i++)
{
    
    System.Console.Write($"{i*i}  ");
}
System.Console.WriteLine();