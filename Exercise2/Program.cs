using System;
using System.Text;

namespace Exercise2
{
    class Program
    {
        class Exercise2
        {
            public static int theFinalProblem(string target)
            {
                string initial = "00000";
                int count = 0;
                StringBuilder ini = new StringBuilder(initial);
                StringBuilder tgt = new StringBuilder(target);

                for (int i = target.IndexOf("1"); i <= target.Length; i++)
                {
                    for (int j = i; j < target.Length; j++)
                    {
                        if (ini[j].Equals(Char.Parse("1")))
                        {
                            ini[j] = Char.Parse("0");
                        }
                        else
                        {
                            ini[j] = Char.Parse("1");
                        }
                    }
                    count++;
                    if (ini.ToString() == tgt.ToString())
                    {
                        break;
                    }
                    else if (ini.ToString() != tgt.ToString() && i == target.Length)
                    {
                        
                        count = -1;
                        break;
                    }
                }

                return count;
            }

            static void Main(string[] args)
            {
                int flips;
                flips = theFinalProblem("01011");
                if (flips < 0)
                {
                    Console.WriteLine("this hasn't solution");
                }
                else
                {
                    Console.WriteLine(flips + " was the minimum flips that required");
                }
                

            }
        }


        
    }
}
