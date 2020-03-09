using System;
using System.Collections.Generic;
using System.Linq;

namespace Balancing_Elements
{
    class Program
    {
        public static int countBalancingElements(List<int> arr)
        {
            int aux;
            int ppar = 0;
            int pimpar = 0;
            int count = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                aux = arr[i];
                arr.RemoveAt(i);

                
                for (int j = 0; j < arr.Count; j++)
                {
                    if ( j % 2 == 0)
                    {
                        ppar = ppar + arr[j];
                    }
                    else
                    {
                        pimpar = pimpar + arr[j];
                    }
                    
                    
                }
                if (ppar == pimpar)
                {
                    count = count + 1;
                }
                arr.Insert(i,aux);
                ppar = 0;
                pimpar = 0;
            }
            return count;
        }
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            numlist.Add(2);
            numlist.Add(2);
            numlist.Add(2);
            //numlist.Add(5);
            //numlist.Add(8);


            Console.WriteLine(" the number of balancing elements is " + countBalancingElements(numlist) );
        }
    }
}
