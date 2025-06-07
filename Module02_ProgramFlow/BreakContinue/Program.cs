﻿using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

            Console.WriteLine("Using Break and Continue : ");
            foreach (int val in values)
            {
                // The Continue statement skips the rest of the loop entirely
                // and jumps to the next iteration (if there is one)
                if (val >= 20 && val <= 29)
                {
                    continue;
                }

                // Print the value
                Console.WriteLine($"val is currently {val}");

                // The break statement stops the loop and exits
                if (val >= 40)
                {
                    break;
                }
            }
        }
    }
}