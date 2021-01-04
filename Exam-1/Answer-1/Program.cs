using System;

namespace Answer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2 = " ";
        
            Console.WriteLine("Enter your string : ");
            str1 = Console.ReadLine();

            foreach (char c in str1)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    str2 = str2 + str1[c];
                }
                else
                {
                   
                }
            }
            Console.WriteLine($"After removing special characters : {str2}");
        }
    }
}