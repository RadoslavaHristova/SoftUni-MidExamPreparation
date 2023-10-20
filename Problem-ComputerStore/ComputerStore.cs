/*
1050
200
450
2
18.50 
16.86 
special

1023 
15
-20
-5.50
450
20 
17.66 
19.30
regular

 */
using System.Diagnostics;

namespace Problem_ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalPriceWithoutTax = 0;

            while (true)
            { 
                if(input == "special") { break; }
                if(input == "regular") { break ; }

                    double partPrice=double.Parse(input);
                totalPriceWithoutTax += partPrice;
                if (partPrice <0)
                {
                    Console.WriteLine("Invalid price!");
                    totalPriceWithoutTax -= partPrice;
                }
                
                input = Console.ReadLine();
            }
            if(totalPriceWithoutTax == 0) 
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double priceWithTax = totalPriceWithoutTax + (totalPriceWithoutTax * 0.2);
            double taxes = priceWithTax - totalPriceWithoutTax;
            
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            if (input=="special")
            {
                double total = priceWithTax - (priceWithTax * 0.1);
                Console.WriteLine($"Total price: {total:F2}$");
            }
            else
            {
                Console.WriteLine($"Total price: {priceWithTax:f2}$");
            }



        }
    }
}