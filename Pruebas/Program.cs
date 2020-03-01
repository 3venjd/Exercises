using Pruebas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pruebas
{
    class Program
    {
        private delegate int Calc(int x, int y);
        static void Main(string[] args)
        {
            /*int i = 0;
            int[] V0 = new int[] {4,13,2,3};

            Func<bool, int, string> func;

            func = (t, i) => { return "yeah"; };

            Console.WriteLine(func(true, 1));
            
            
            Calc calcular = (x, y) => { return x * y; };
            Console.WriteLine(calcular(4, 3));
            
            foreach (var number in V0)
            {
                Console.WriteLine(V0[i]);
                i++;
            }
            --------------------------------------------------------------
            List<int> V = new List<int>();
            V.Add(4);
            V.Add(13);
            V.Add(2);
            V.Add(3);
            V.ForEach(item => Console.WriteLine(item ));
            V.Sort();
            Console.WriteLine(V.Count);
            V.ForEach(item => Console.WriteLine(item));

            /*Son la misma sentencia
             * foreach (var item in V)
            {
                Console.WriteLine(item);
            }
            
             --------------------------------------------------------------
             */

            List<Numbers> V,V2;
            V = new List<Numbers>();
            V.Add(new Numbers { Num = 4 });
            V.Add(new Numbers { Num = 13 });
            V.Add(new Numbers { Num = 2 });
            V.Add(new Numbers {Num = 3 });
            V2 = V.Where(n => (n.Num % 2) == 0).ToList();
            V2.ForEach(n => Console.WriteLine(n.Num));



            Console.ReadKey(); //mantener en espera para visualizar los datos
        }
    }
}
