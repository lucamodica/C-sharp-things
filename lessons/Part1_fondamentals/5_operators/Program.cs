using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            //Sum
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            //Sub
            x = 5, y = 3;
            Console.WriteLine(x - y);

            //Mult
            x = 5, y = 6;
            Console.WriteLine(x * y);  

            //Div
            x = 6, y = 2;
            Console.WriteLine(x / y);  

            //Mod
            x = 6, y = 2;
            Console.WriteLine(x % y);  

            //Inc/Dec
            x++, y++;
            Console.WriteLine(x);  
            Console.WriteLine(y);

            //Assignements
            x = 10;
            x += 5;
            Console.WriteLine(x);  

            //Exponent
            x = 5;
            x ^= 3;
            Console.WriteLine(x);

            //Comparisons
            x = 5;
            y = 3;
            Console.WriteLine(x == y);  // returns False because 5 is not equal to 3

            //Logical
            x = 5;
            Console.WriteLine(x > 3 || x < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)

        }
    }
}
