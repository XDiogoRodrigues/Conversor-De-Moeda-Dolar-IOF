using System;
using System.Globalization;
namespace ConversorMoedaDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while(choice == 1)
            {
                try
                {
                    Console.Write("What is the dollar exchange rate?\nValue: ");
                    double quoteValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("how many dollars will you buy?\nQuantity: ");
                    double quantityDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ConversorDolar conversorDollar = new ConversorDolar(quantityDollar, quoteValue);

                    conversorDollar.VerificationValue();
                    choice = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Error: You need to enter number!");
                }
                catch(DomainException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
                Console.Write("Would you like to make another quote (0 - Exit | 1 - Quote again):\nChoice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                }
                catch (FormatException)
                {
                    Console.WriteLine($"Error: Enter a valid value as advertised!");
                }
                

            }
           
           

        }
    }
}
