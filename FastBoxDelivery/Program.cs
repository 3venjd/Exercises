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
                if (boxes[i] != 0)
                {
                    for (int j = 0; j < boxes[i]; j++)
                    {
                        acum = acum + 2*(size - i);
                    }
                    for (int k = 0; k < size; k++)
                    {
                        boxes[k] = boxes[k] - 1;
                    }
                }
            }

            return acum;
        }
        static void Main(string[] args)
        {
            List<int> box = new List<int>();
            box.Add(1);
            box.Add(5);
            box.Add(2);

            Console.WriteLine("the list is:");
            box.ForEach(x => Console.WriteLine(x));

            Console.Write("the minimum time required is ");
            Console.WriteLine(minTime(box));


        }
    }
}
