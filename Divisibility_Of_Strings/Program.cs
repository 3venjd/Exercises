using System;
using System.Linq;

namespace Divisibility_Of_Strings
{
    class Program
    {
        public static int findSmallestDivisor(string s, string t)
        {

            string u = " ";
            bool flag = false;
            int r = -1;
            if (s.Length % t.Length == 0)
            {
                if (s.Contains(t))
                {
                    for (int i = 0; i < t.Length; i++)
                    {
                        u = u[i] + t[i].ToString();
                        for (int j = 0; j < t.Length; j++)
                        {
                            u = u + u;
                            if (u == t)
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            r = i;
                        }
                        u.ToList().RemoveAt(i);
                        
                    }
                }
            }
            return r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(findSmallestDivisor("lrbblrbb","lrbb"));
        }
    }
}
