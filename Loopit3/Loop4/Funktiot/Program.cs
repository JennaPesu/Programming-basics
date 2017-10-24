using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktiot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa annetun määrän tähtiä");

            int n;
            while (true)
            {
                Console.Write("Tähtien määrä:");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Luku {0}, ei ole sallittu luku, n");
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();

        }
        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res; 
        }
    }
}
