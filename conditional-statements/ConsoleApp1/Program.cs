using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä numero 1:");
            string numero1 = Console.ReadLine();
            int numx = int.Parse(numero1);

            Console.WriteLine("Syötä numero 2:");
            string numero2 = Console.ReadLine();
            -int numy = int.Parse(numero2);

            Console.WriteLine("Syötä numero 3:");
            string numero3 = Console.ReadLine();
            int numz = int.Parse(numero3);

            if (numx < numy)
            {
                if (numx < numy)
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"{numx}, {numy}, {numz}");
                    }
                    else
                    {
                        Console.WriteLine($" {numx}, {numz}, {numy}");
                    }
                }
                else
                {
                    Console.WriteLine($"{ numz},{ numx}, { numy}");
                }
            }
            else
            {
                if (numx < numz)
                {
                    Console.WriteLine($"{numy}, {numx}, {numz}"); 
                } 
                else
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"{numy}, {numz}, {numx}"); 
                    } 
             else
                    {
                        Console.WriteLine($" {numz}, {numy}, {numx}");
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
