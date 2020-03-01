using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Exercise1
    {
        static int maxTickets(List<int> tickets)
        {
            int cont = 1;
            int max_val = 1;
            tickets.Sort();

            for (int i = 0; i < tickets.Count - 1; i++)
            {
                if (tickets[i + 1] - tickets[i] == 0 || tickets[i + 1] - tickets[i] == 1)
                {
                    cont++;
                }
                else
                {
                    if (cont > max_val)
                    {
                        max_val = cont;
                        cont = 0;
                    }
                }
            }
            return max_val;
        }

        static void Main(string[] args)
        {
            
            int max;
            List<int> V = new List<int>();

            
            V.Add(4);
            V.Add(13);
            V.Add(2);
            V.Add(3);
            
            /*
            V.Add(5);
            V.Add(10);
            V.Add(12);
            V.Add(1);
            V.Add(10);
            V.Add(4);
            */

            /*
            V.Add(10);
            V.Add(1);
            V.Add(5);
            V.Add(2);
            V.Add(5);
            V.Add(5);
            V.Add(2);
            V.Add(6);
            V.Add(3);
            V.Add(5);
            V.Add(3);
            */

            //V.ForEach(item => Console.WriteLine(item));
            max = maxTickets(V);
            Console.WriteLine("the max value is " + max );
            Console.ReadKey();

        }

    }

}
