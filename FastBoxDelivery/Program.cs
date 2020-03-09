using System;
using System.Collections.Generic;
using System.Linq;

namespace FastBoxDelivery
{
    class Program
    {
        public static long minTime(List<int> boxes)
        {

            //TODO WITHOUT BUCLES
            long acum;
            //if value is in the buttom
            if (boxes.Max() == boxes[0])
            {
                acum = (boxes.Count() * boxes.Max()) + boxes.Sum();
            }
            //when the value is in the top
            else if (boxes.Max() == boxes.Last())
            {
                acum = boxes.Sum() * 2;
            }
            else
            {
                //Find the formula when the value is in the middle

                // ???
                acum = 1;
            }


            return acum;
        }
        static void Main(string[] args)
        {
            List<int> box = new List<int>();
            box.Add(1);
            box.Add(8);
            box.Add(3);

            Console.WriteLine("the list is:");
            box.ForEach(x => Console.WriteLine(x));

            Console.Write("the minimum time required is ");
            Console.WriteLine(minTime(box));


        }
    }
}
