/*
    * Author: Vanessa Garcia
    * Course: COMP-003A
    * Purpose: Methods and XML Comments 5
    */

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintSeparator();
            PrintSeparator("Separator with string parameter");
            IsoscelesTriangleBuilder('*', 5);
        }
        static void PrintSeparator()
        {
            Console.WriteLine(new string('*', 50));
        }
        /// <summary>
        /// Outputs 50 asterisks in the console.
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
        }

        /// <summary>
        /// Prints the given string as a separator
        /// </summary>
        /// <param name="separator">The string to print as a separator</param>
        static void PrintSeparator(string separator)
        {
            Console.WriteLine(separator);
        }

        /// <summary>
        /// Builds an isosceles triangle using the given character and size
        /// </summary>
        /// <param name="inputCharacter">The character to use for building the triangle</param>
        /// <param name="size">The size of the triangle</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            // increasing triangle
            for (int i = 1; i <= size; i++)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }
            // decreasing triangle
            for (int i = size - 1; i >= 1; i--)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }
        }
    }
}




        
