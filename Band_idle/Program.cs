//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.Write("Введите ряд чисел, разделенных запятой : ");
            string seriesOfNumbers = Console.ReadLine();

            seriesOfNumbers = seriesOfNumbers + ",";    

          
       

            string seriesNew = RemovingSpaces(seriesOfNumbers);

            int[] arrayOfNumbers = arrayOfNumbers(seriesNew);

            PrintArry(arrayOfNumbers);
