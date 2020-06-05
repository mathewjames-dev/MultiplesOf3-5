using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplesOf3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * BRIEF:
             * If we list all the natural numbers below 10 that are multiples of 3 or 5,
             * we get 3, 5, 6 and 9. The sum of these multiples is 23.
             * Find the sum of all the multiples of 3 or 5 below 1000.
             */
            Console.WriteLine("Right.. Let's do this!");

            // We setup an empty integer type list and call it multiples.
            // This will house all the multiples of 3 and 5 below 100.
            List<int> multiples = new List<int>();

            // Then we loop every multiple of 3 up to a 1000 and add it to the list.
            for (int i = 1; i <= 1000; i++)
            {
                // Checks to see if i is a multiple of 3 or 5 by checking their remainders.
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }

            Console.WriteLine(multiples.Sum());
        }
    }
}
