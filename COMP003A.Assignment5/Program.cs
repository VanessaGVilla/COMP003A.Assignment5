﻿/*
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


    }
}