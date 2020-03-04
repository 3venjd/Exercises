using System;
using System.Collections.Generic;
using System.Linq;

namespace FastBoxDelivery
{
    class Program
    {
        public static long minTime(List<int> boxes)
        {
            
            long acum = 0;
            int size = boxes.Count;

            for (int i = 0; i < size; i++)
            {
                acum = acum + size - i;
                for (int j = 0; j < size; j++)
                {
                    if (boxes[j] != 0)
                    {
                        boxes[j] = boxes[j] - 1;
                        acum = acum + 1;
                    }
                }
            }
            return acum;
        }
        static void Main(string[] args)
        {
            List<int> box = new List<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);

            Console.WriteLine("the list is:");
            box.ForEach(x => Console.WriteLine(x));

            Console.Write("the minimum time required is ");
            Console.WriteLine(minTime(box));
            

        }
    }
}
