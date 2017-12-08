using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 100 lukua");
            Random rnd = new Random();


            double size = 100;
            int[] number = new int [(int)size];
            int sum = 0; 
            for (int i = 0; i < size; i++)
                number[i] = rnd.Next(50); 
           
           
                for(int i = 0; i < size; i++)
                    sum += number[i];

            for (int i = 0; i < size; i++)
                Console.WriteLine($" {i+1}. {number[i]} ");
            Console.WriteLine($"Lukujen summa on {sum} ja keskiarvo {sum / size} ");
            Console.ReadKey();
        } 

    }
}
