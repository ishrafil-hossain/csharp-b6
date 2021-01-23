using System;
using System.Numerics;
namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');

            var str1 = str[0];
            var str2 = str[1];

            BigInteger a = BigInteger.Parse(str1);
            BigInteger b = BigInteger.Parse(str2);
            BigInteger c = BigInteger.Multiply(a, b);
            Console.WriteLine(c);
        }
    }
}
