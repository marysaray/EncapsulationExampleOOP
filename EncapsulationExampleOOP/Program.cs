using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExampleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array of 5 individual die to reference
            Die[] dice = new Die[5]; // each element in the array is a Die object.

            // create a loop to go through each one.
            for (int i = 0; i < dice.Length; i++)
            {
                // create the die, call the constructor to roll the die
                dice[i] = new Die(); // set to avoid default settings of 0 || null.

                // display the values
                Console.WriteLine(dice[i].Value);
            }

            Console.ReadKey(); // Keeps program open.
        }
    }
}
