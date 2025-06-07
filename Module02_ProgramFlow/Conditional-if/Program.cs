using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // If - Else
            if (theVal == 50)
            {
                Console.WriteLine("theVal is 50");
            }
            else if (theVal >= 51 && theVal <= 60)
            {
                Console.WriteLine("theVal is between 51 and 60");
            }
            else
            {
                Console.WriteLine("theVal is something else");
            }

            // ------------------------------------
            // Using the Ternary Operator ?:

            // A two-case if-then
            if (theVal < 50)
            {
                Console.WriteLine("theVal is small");
            }
            else
            {
                Console.WriteLine("theVal is large");
            }

            // Can be replaced by the Ternary Operator ?:
            Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");
        }
    }
}