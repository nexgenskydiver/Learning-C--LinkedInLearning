using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            string a = "abcd", b = "efgh";

            // Basic math operators are +, -, /, *
            Console.WriteLine("------- Basic Math -------");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            // Increment / Decrement Operators
            Console.WriteLine("------- Shorthand -------");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Operators can be shorthand: a = a + b
            a += b;
            Console.WriteLine(a);

            // Logical Operators && ||
            Console.WriteLine("------- Logic Operators -------");
            Console.WriteLine(x > y && y >= 5);
            Console.WriteLine(x > y || y >= 5);

            // Null-coalescing Operators
            string str = null;
            // The ?? Operator uses LEFT operand if NOT NULL, or RIGHT one if it is
            Console.WriteLine(str ?? "Unknown String");

            // The ??= Operator assigns the RIGHT operand if the LEFT is NULL
            str ??= "New String";
            Console.WriteLine(str);
        }
    }
}