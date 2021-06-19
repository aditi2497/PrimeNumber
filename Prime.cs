using System;

    class Prime
    {
        public static bool isprime(int n)
        {
            if (n <= 1)
                return false;
            int i = 2;
            while (i * i <= n) {
                if (n % i == 0)
                    return false;


                i++;
                    }
            return true;
        }
           
        static void Main(string[] args)
        {
        try
        {
            while (true)
            {
                Console.Write("Enter the number to be checked : ");
                int n = Convert.ToInt32(Console.ReadLine());
       
                if (isprime(n))
                    Console.WriteLine("It is a prime number");
                else
                    Console.WriteLine("It is not a prime number");
                Console.Write("Do you wish to continue (y/n)");
                char ch = Console.ReadLine()[0];
                if (ch == 'n')
                {
                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        }
    }