// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
System.Console.WriteLine("Введите пятизначное число");
int Num = int.Parse(Console.ReadLine());
if (Num > 9999 & Num<100000)
    {
        int temp = Num;
        int revert = 0;

        while(temp>0)
        {

            revert = (revert*10) + (temp%10);
            temp/=10;

        }
        
        if(Num==revert)
        {
            System.Console.WriteLine($"число {Num} - палиндром");
        }
        else
        {
            System.Console.WriteLine($"число {Num} - непалиндром");
        }

    }   

else{System.Console.WriteLine("число не является пятизначным");}
  