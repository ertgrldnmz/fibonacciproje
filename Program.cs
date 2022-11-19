int n1 = 0, n2 = 1, n3=0, i;
            double number;
            Console.Write("Enter the number of elements:");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(n1);
                Console.ReadLine();
            }
            else if (number == 1)
            {
                Console.WriteLine(n2);
                Console.ReadLine();
            }
            else if (number >1)
            {
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                for (i = 2; i < number; ++i)
                {
                    n3 = n1 + n2;
                    Console.WriteLine(n3 + " ");
                    n1 = n2;
                    n2 = n3;

                }
            }
            else
            {
                Console.WriteLine("Negatif Sayı Girdiniz Hesaplanamaz");
            }



            Console.WriteLine("------------------------");
            Console.WriteLine(n3 );
            double  ort = n3 / number;
            Console.WriteLine("Ortalama = "+ort);
            Console.ReadLine();
        