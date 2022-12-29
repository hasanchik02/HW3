// Задача 19: Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли 
//оно палиндромом. 12421

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int s1 = num / 10000;
int e1 = num % 10;


//if (num => 10000 && num <= 99999)
    
    if (s1 == e1)
    {
        int s2 = (num / 10) % 10;
        int e2 = (num / 1000) % 10;
            if (s2 == e2)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
    }
    else
    {
      Console.WriteLine("Число не является палиндромом");   
    }

