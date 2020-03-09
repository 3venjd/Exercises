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
                int max_value_index = boxes.IndexOf(boxes.Max());
                var List_values_below_max = boxes.SkipLast(max_value_index);
                acum = List_values_below_max.Sum(x => x * (List_values_below_max.ToList().IndexOf(x)+1)) + boxes.Sum();

                
            }


            return acum;
        }
        static void Main(string[] args)
        {
            List<int> box = new List<int>();
            box.Add(5);
            box.Add(7);
            box.Add(4);



            Console.WriteLine("the list is:");
            box.ForEach(x => Console.WriteLine(x));

            Console.Write("the minimum time required is ");
            Console.WriteLine(minTime(box));


        }
    }
}
