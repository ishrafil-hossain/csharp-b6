using System;

namespace Answer_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            string str1 = Console.ReadLine();
            string[] str2 = str1.Split(' ');
            long n = 0, sum = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                if (i == 0)
                {
                    n = long.Parse(str2[i]);
                }
                else
                {
                    sum = n - long.Parse(str2[i]);

                }

            }
            Console.WriteLine($"result is : {sum}");
        }
    }
}
