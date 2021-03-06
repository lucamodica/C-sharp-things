﻿using System;

namespace try_catch
{

    
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(15);
            try //Block of code to try
            {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e) //Block of code to handle errors
            {
                Console.WriteLine("Something went wrong.");
            }  
            finally //Excecute its code, regardless og the result
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}
