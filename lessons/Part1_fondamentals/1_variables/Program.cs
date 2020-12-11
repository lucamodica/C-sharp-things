using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //** Variables **
            int myNum = 5, a = 6, b = 7; //Integer value
            myNum = 10 //Assign another value
            Console.WriteLine(myNum + a + b);
            

            //** Constant **
            const int constNum = 40, another = 60;
            constNum = 30; //This will generate an error!
        }
    }
}
