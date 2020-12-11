using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement
            if (20 > 18) 
            {
                Console.WriteLine("20 is greater than 18");
            } 

            //if then else statement
            int time = 20;
            if (time < 18) 
            {
                Console.WriteLine("Good day.");
            } 
            else 
            {
                Console.WriteLine("Good evening.");
            }

            //if then else if then else statement
            time = 22;
            if (time < 10) 
            {
                Console.WriteLine("Good morning.");
            } 
            else if (time < 20) 
            {
                Console.WriteLine("Good day.");
            } 
            else 
            {
                Console.WriteLine("Good evening.");
            }
        }
    }
}
