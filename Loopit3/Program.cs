using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee {N} arvon");
            int luku = 1;
            {
                luku = int.Parse(Console.ReadLine());
                int i = 1;
                int parillinen = 0;
                int pariton = 0;
                while (i <= luku)
                {
                    if (i % 2 != 0)
                    {
                        pariton = pariton + i;
                    }
                    else
                    {
                        parillinen = parillinen + i;
                    }
                    i++;
                }


                Console.WriteLine($"Parittomien summa = " + pariton);
                Console.WriteLine($"Parillisten summa =" + parillinen);
                Console.ReadKey();



            }
        }
    }
}
