using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Type order:

            // Automatic casting: int to double (that is a smaller type)
            // char -> int -> long -> float -> double
            int myInt = 9;
            double myDouble = myInt;
            bool myBool = true;      

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Manual casting: double to int (that is a bigger type)
            // double -> float -> long -> int -> char
            myDouble = 9.78;
            myInt = (int) myDouble;    

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            //Casting funcs
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}
