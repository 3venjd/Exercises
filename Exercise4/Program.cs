using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        public static int segment(int x, List<int> arr)
        {
            int max = 0;
            int min;

            for (int i = 0; i <= arr.Count-x; i++)
            {
                min = arr[i];
                for (int j = i+1; j <= x-1; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                    }
                }
                if (min > max)
                {
                    max = min;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            List<int> V = new List<int>();
            V.Add(1);
            V.Add(2);
            V.Add(3);
            V.Add(1);
            V.Add(2);

            int result = segment(1, V);

            Console.WriteLine("the maximun value is " + result);
        }
    }
}
