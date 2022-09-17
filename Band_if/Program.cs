Console.Write("Введите ряд чисел, разделенных запятой : ");
            string seriesOfNumbers = Console.ReadLine();

            seriesOfNumbers = seriesOfNumbers + ",";    

          
       

            string seriesNew = RemovingSpaces(seriesOfNumbers);

            int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

            PrintArry(arrayOfNumbers);


