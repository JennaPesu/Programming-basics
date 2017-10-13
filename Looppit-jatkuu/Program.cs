using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looppit_jatkuu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee {N} kertoman arvon. Anna luku, jonka kertoma lasketaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number); 
            int i = 0;
            int f = 1;
            do
            {
                i = i + 1;
                f = f * i;
                Console.WriteLine($"{i}!={f}"); //5!=120
            } while (i < number);
            Console.ReadKey(); 


        }
    }     
}
