using System;

namespace Primes
{
    class Program
    {
        bool val = false;
        static void Main(string[] args)
        {
            string numberz;
            Console.WriteLine("What number would you like to enter");
            numberz = Convert.ToDouble64(Console.ReadLine());

            Primes(numberz);
            if (val == true)
            {
                Console.WriteLine("Your number is not prime");
            }
            else
            {
                Console.WriteLine("Your number is prime");
            }
            twoint();
            add();
        }
        static void Primes(double num)
        {

            for (int x = 2; x > num - 1; x = x + 1)
            {
                if (num / x = 0)
                {
                    val = true;
                }
            }


        }


        static void twoint()
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("What is you number 1?");
            num1 = Convert.ToDouble64(Console.ReadLine());
            Console.WriteLine("What is you number 2?")
            num2 = Convert.ToDouble64(Console.ReadLine());
            for (int x = num1; x > num2; x = x + 1)
            {
                Primez(x);
                if (val = false)
                {
                    Console.WriteLine("[0]  is not prime" x);
                }
                else
                {
                    Console.WriteLine("[0]  is  prime" x);
                }


            }

        }
        static void add()
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("What is you number 1?");
            num1 = Convert.ToDouble64(Console.ReadLine());
            Console.WriteLine("What is you number 2?");
            num2 = Convert.ToDouble64(Console.ReadLine());
            Console.WriteLine("[0] is your sum of these numbers" num1 + num2);
        }
        
        



            
        
    }
}
        

    

    

