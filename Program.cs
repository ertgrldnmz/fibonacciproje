int number1 = 0, number2 = 1, number3=0, i;
            double number;
            Console.Write("eleman numarsınızı giriniz.");
            number = Convert.ToInt16(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(number1);
                Console.ReadLine();
            }
            else if (number == 1)
            {
                Console.WriteLine(number2);
                Console.ReadLine();
            }
            else if (number >1)
            {
                Console.WriteLine(number1);
                Console.WriteLine(number2);
                for (i = 2; i < number; ++i)
                {
                    number3 = number1 + number2;
                    Console.WriteLine(number3 + " ");
                    number1 = number2;
                    number2 = number3;

                }
            }
            else
            {
                Console.WriteLine("Negatif Sayı Girdiniz Hesaplanamaz");
            }



            Console.WriteLine("------------------------");
            Console.WriteLine(number3 );
            double  ort = number3 / number;
            Console.WriteLine("Ortalama = "+ort);
            Console.ReadLine();
        