using System;

namespace booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic printing
            bool carbonaraAmazing = true;
            bool AnanasPizzaFine = false;
            Console.WriteLine(carbonaraAmazing);   // Outputs True
            Console.WriteLine(AnanasPizzaFine);   // Outputs False

            //Using comparison to print bool values
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // returns True, because 10 is higher than 9
            Console.WriteLine(x == 10); // returns True, because the value of x is equal to 10
        }
    }
}
