using System;
using System.Linq;

namespace Balancing_Parentheses
{
    class Program
    {
        public static int getMin(string s)
        {
            int size = s.Length;
            int izq, der,r;

            izq = s.Where(i => i.ToString() == "(").Count();
            der = s.Where(i => i.ToString() == ")").Count();
            r = der - izq < 0 ?  (der - izq) * -1 : (der - izq);

            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int r = getMin("()()");

            Console.WriteLine("the minimum value is " + r);
        }
    }
}
