using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions 
            Console.WriteLine("Ohjelma tulostaa parillisen tai parittoman");
            bool isNumber;
            do
            {


                Console.Write("Syötä luku: ");
                string userInput;
                userInput = Console.ReadLine();

                int evaluetednumber;
                isNumber = int.TryParse(userInput, out evaluetednumber);
                // Program logic
                if (evaluetednumber % 2 == 1)
                {
                    Console.WriteLine($"Syötit luvun {evaluetednumber}, se on pariton");
                }
                else if (evaluetednumber % 2 == 0)
                {
                    Console.WriteLine($"Syötit luvun {evaluetednumber}, se on parillinen");
                } 
                else
                { 
                    Console.WriteLine("Syötit muuta kun numeron");
                }
            } while (isNumber == true);
            Console.ReadKey();



        }
    }
}