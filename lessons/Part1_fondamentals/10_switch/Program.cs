﻿using System;

namespace switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic switch statement
            int day = 4;
            switch (day) 
            {
                case 1:
                Console.WriteLine("Monday");
                break;
                case 2:
                Console.WriteLine("Tuesday");
                break;
                case 3:
                Console.WriteLine("Wednesday");
                break;
                case 4:
                Console.WriteLine("Thursday");
                break;
                case 5:
                Console.WriteLine("Friday");
                break;
                case 6:
                Console.WriteLine("Saturday");
                break;
                case 7:
                Console.WriteLine("Sunday");
                break;
            }

            //Switch with a default case
            int day = 4;
            switch (day) 
            {
                case 6:
                Console.WriteLine("Today is Saturday.");
                break;
                case 7:
                Console.WriteLine("Today is Sunday.");
                break;
                default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
            }
    }
}
