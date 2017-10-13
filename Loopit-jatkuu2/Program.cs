using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopit_jatkuu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee {N} lukujen summan. Anna luku, jonka summa lasketaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number); 
            int i = 0;
            int f = 0;
            do
            {
                i = i + 1;
                f += i;
                Console.WriteLine($"{i-1}+{i}={f}"); //10 
            } while (i < number);
            Console.ReadKey();
        }
    }
}
