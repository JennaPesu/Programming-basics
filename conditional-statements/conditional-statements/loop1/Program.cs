using System;

namespace LoopTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee kertoma. Anna luku, jonka kertoma lasketaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput); 
            //int.TryParse(userInput, out int number); 
            int i = 0;
            int f = 1;
            do
            {
                i = i + 1;
                f = f * i;
                Console.WriteLine($"{i}!={f}"); // 5!=120
            } while (i < number);

            Console.ReadKey();  

            //for (int j=1; 1 < number; j++)
            //{
            //    f = f * j;
            //    Console.WriteLine($" {i}! = {f}"); //5! = 120 
            //}
            //Console.WriteLine($"Syötit: {number}\n Vastaus: {f}");
            //Console.ReadKey(); 


            //do 
            //( 
            // i = i + 1; 
            // //i++ 
            // f = f * i; 
            // COnsole.WriteLine($" {i}! = {f}"); //5! = 120 
            //} while (i < number);  


            /* 
              while (i < number) 
             { 
              i = i + 1; 
             f = f * i; 
              Console.WriteLine($" {i}! = {f}"); //5! = 120 
             } 
             */
        }
    }
}
