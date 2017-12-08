using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkitiot1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa kahdesta arvosta pienemmän");
            Console.Write("Syötä 1. luku: ");
            string userInput = Console.ReadLine();
            int numberX = int.Parse(userInput);

            Console.Write("Syötä 2. luku: ");
            userInput = Console.ReadLine();
            int numberY = int.Parse(userInput);


            
            Console.WriteLine($" pienempi luvuista on {minimi(numberX, numberY)} ");
            Console.ReadKey(); 
        }

        static int minimi(int x, int y)
        {
            if (x < y)
                return x;
            else
                return y;
        } 
    } 
}
