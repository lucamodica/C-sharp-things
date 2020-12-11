using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While-do loop
            int i = 0;
            while (i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }

            //Do-while loop
            i = 0;
            do 
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            //For loop
            for (i = 0; i < 5; i++) 
            {
                Console.WriteLine(i);
            }

            //Foreach loop
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string s in cars) 
            {
                Console.WriteLine(s);
            }   

            //Loop broken with "break" statement
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                break; //The loop will be interrupted
                }
                Console.WriteLine(i);
            }

            //Iteration skipped with "continue" statement
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                continue;
                }
                Console.WriteLine(i);
            } 
        }
    }
}
