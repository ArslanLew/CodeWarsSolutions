using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndLowestV1
{
    class Program
    {
        //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
        static void Main(string[] args)
        {
            string TestString = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";
            string[] SplitString = TestString.Split(' ');
            int[] nums = Array.ConvertAll(SplitString, int.Parse);
            int HighestNum = Convert.ToInt32(nums[0]);
            int LowestNum = Convert.ToInt32(nums[0]);
            foreach (int num in nums)
            {
                if (num > HighestNum)
                {
                    HighestNum = num;
                }
                if (num < LowestNum)
                {
                    LowestNum = num;
                }
            }
            Console.WriteLine("Highest: {0}, Lowest: {1}",HighestNum, LowestNum);

            Console.ReadKey(true);
        }
    }
}
