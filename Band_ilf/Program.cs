//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число");
           int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (c > 0)
            {
                int num = c % 10;
                c = c / 10;
                sum = sum + num;
            }
            Console.WriteLine("сумма всех цифр в числе равна: " + sum);