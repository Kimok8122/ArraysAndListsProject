using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
    

        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 - done

            var numbersArray = new int[10];


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = i + 1;
            }

            var even = new List<int>();
            var odd = new List<int>();

            foreach (var i in numbersArray)
            {

                if (i % 2 == 0)
                {
                    even.Add(i);
                }

                else
                {
                    odd.Add(i);
                }
            }


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var i in even)
            {
                Console.WriteLine($"Even number: {i}");
            }

            Console.WriteLine("");

            foreach (var i in odd)
            {
                Console.WriteLine($"Odd number: {i}");
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
