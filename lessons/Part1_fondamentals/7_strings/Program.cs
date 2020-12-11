using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {


            //Creating a string
            string greeting = "Hello";
            Console.WriteLine(greeting);

            //Find length
            Console.WriteLine("The length of the txt string is: " + greeting.Length);

            //To Upper
            Console.WriteLine(greeeting.ToUpper());

            //To Lower
            Console.WriteLine(txt.ToLower());

            //Concatenation
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName; //Using '+' operator
            string namee = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            //String interpolation
            name = $"My full name is: {firstName} {lastName}"; //Note the '$' ahead
            Console.WriteLine(name);

            //Access string character by using indexes
            Console.WriteLine(greeting[0]);

            //Locate index of character
            Console.WriteLine(myString.IndexOf("e")); //Pring 1
            Console.WriteLine(myString.IndexOf("f")); //Pring -1

            //Substring
            // Full name
            name = "John Doe";
            // Location of the letter D
            charPos = name.IndexOf("D");
            // Get last name
            lastName = name.Substring(charPos);
            // Print the result
            Console.WriteLine(lastName);

            //Special and escape characters
            //We can use the '"' characterr thanks to the backslashes use
            string txt = "We are the so-called \"Vikings\" from the north.\n\n"; 
            Console.WriteLine(txt);

        }
    }
}
