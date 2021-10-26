using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. 
            If the two numbers are equal return a or b.
            Note: a and b are not ordered!
            */
            int a = 0;
            int b = -1;
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            //int value = ((max - min)/2) * (min + max);
            int value = ((max - min) + 1) * (max + min) / 2;
            Console.WriteLine(value);

        }
    }
}
