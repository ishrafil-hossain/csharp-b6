using System;

namespace Answer_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your number : ");

            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            int i;
            Console.WriteLine("This number's all prime factor is : ");
            for (i = 2; i < n; i++)
            {

                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
    
}
