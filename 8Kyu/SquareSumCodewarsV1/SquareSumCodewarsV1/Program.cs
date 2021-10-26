using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSumCodewarsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Complete the square sum function so that it squares each number passed into it and then sums the results together.
            //For example, for [1, 2, 2] it should return 9 because 1 ^ 2 + 2 ^ 2 + 2 ^ 2 = 9.

            int[] TestArray = new int[] { 5, 3, 4 };
            int sum = 0;
            foreach (int num in TestArray)
            {
                sum = sum + num * num;
            }
            Console.WriteLine(sum);
            Console.ReadKey(true);
        }
    }
}
