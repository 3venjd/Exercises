using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        public static long kSub(int K, List<int> nums)
        {
            int acum;
            int count = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % K == 0)
                {
                    count++;
                }
                acum = nums[i];
                for (int j = i + 1; j < nums.Count; j++)
                {
                    acum = acum + nums[j];
                    if (acum % K == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            List<int> V = new List<int>();
            
            V.Add(5);
            V.Add(10);
            V.Add(11);
            V.Add(9);
            V.Add(5);
            long result = kSub(5, V);
            Console.WriteLine("the number of k-subsequences is " + result);
        }
    }
}
