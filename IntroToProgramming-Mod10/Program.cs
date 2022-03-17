using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_Mod10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            string myString = "Hello";
            char myChar = 'A';

            // EX 1 Task 1.2:  Perform an implicit cast from the value type to the reference type by assigning
            // the three variables to the array.
            Object[] myArray = new object[] { myInt, myString, myChar };

            // EX 1 Task 1.2:  Create another variable
            // Convert myInt to a Double by suing implicit and widening casting
            double myDouble = (int)myArray[0];

            // Convert myDouble to an integer by using explicit cast
            myInt = (int)myDouble;

            // EX 1 Task 2:  Cast the variables in the aray back to their original data types.
            int newInt = (int)myArray[0];
            string newString = (string)myArray[1];
            char newChar = (char)myArray[2];

            Console.ReadKey();


        }
    }
}
