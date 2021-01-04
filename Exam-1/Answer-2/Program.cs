using System;

namespace Answer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string : ");
            string str1 = Console.ReadLine();
            string str2 = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 = str2 + str1[i].ToString();
            }

            if (str1 == str2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
