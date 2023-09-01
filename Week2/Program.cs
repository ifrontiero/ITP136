using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Earl's Garage \n");

            string? inputString;

            // Oil change
            Console.Write("Enter oil change price: ");
            inputString = Console.ReadLine();

            double oilChangePrice = Convert.ToDouble(inputString);

            // Tires
            Console.Write("Enter tire price: ");
            inputString = Console.ReadLine();

            double tirePrice = Convert.ToDouble(inputString);

            // Inspection
            Console.Write("Enter inspection price: ");
            inputString = Console.ReadLine();

            double inspectionPrice = Convert.ToDouble(inputString);

            // Calculate Subtotal
            double subtotal = oilChangePrice + tirePrice + inspectionPrice;
            Console.WriteLine("Subtotal: " + subtotal.ToString("C"));

            // Calculate tax
            double tax = subtotal * 0.06;
            Console.WriteLine("Tax: " + tax.ToString("C"));

            // Ouput total
            double total = subtotal + tax;
            Console.WriteLine("Total: " + total.ToString("C"));
        }
    }
}