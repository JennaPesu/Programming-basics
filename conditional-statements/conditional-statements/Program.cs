using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Define instructions 
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            bool isNumber;
            do
            { 


            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();

            int evaluetednumber;
            isNumber = int.TryParse(userInput, out evaluetednumber);
                // Program logic
                if (isNumber == true)
                {
                    if (evaluetednumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluetednumber} on negatiivinen");
                    }
                    else if (evaluetednumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluetednumber} on negatiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluetednumber} on nolla");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kun numeron");
                }
            } while(isNumber == true);
            Console.ReadKey();
            
             
         
        }
    }
}
