using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int discount = 0;
            int price = 16;
            bool discounted = false;
                Console.Write("ikä ");
            int age = int.Parse(Console.ReadLine());

            if (age < 7)
            {
                discount = 100;
                discounted = true;
            } 
            else if (age >= 7 && age <= 15)
            {
                discount = 50;
                discounted = true; 
            }

            //varusmies 
            Console.Write("Oletko varusmies? Y/N: ");
            string vastaus = Console.ReadLine();
            bool varusmies; 
            if (vastaus == "Y" || vastaus == "y")
            {
                varusmies = true; 
            } 
            else
            {
                varusmies = false; 
            } 
            if (varusmies == true && discounted == false)
            {
                discount = 50;
                discounted = true; 
            }

            //opiskelija 
            Console.Write("OLetko opiskelija? Y/N");
            string vastaus1 = Console.ReadLine();
            Console.Write("OLetko MTK:N jäsen? Y/N");
            string vastaus2 = Console.ReadLine();

            bool mtk;
            bool opiskelija; 

            if (vastaus1 == "Y" || vastaus1 == "y")
            {
               opiskelija = true; 
            } 
            else 
            {
                opiskelija = false; 
            }  

            if (vastaus2 == "y" || vastaus2 == "y")
            {
                mtk = true; 
            } 
            else
            {
                mtk = false; 
            } 
            if (opiskelija == true && mtk == true && discounted == false)
            {
                discount = 60;
                discounted = true; 
            }
            else 
            {
                if (opiskelija == true && discounted == false)
                {
                    discount = 45;
                    discounted = true;
                }
                    else if (mtk == true && discounted == false)
                {
                    discount = 15;
                    discounted = true;
                } 
            }

            decimal lopullinenhinta = price - (price * (discount / 100m));
            Console.WriteLine($"Lopullinen hintasi oli: {lopullinenhinta}");
            Console.ReadKey(); 


        }
    }
}
