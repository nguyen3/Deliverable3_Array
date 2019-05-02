/*
    Author: Trang Nguyen
    Date: 1/4/2019
    Comments: This C# Console application code demonstrates the use of
              Arrays to display 25 elements
*/

using System;

namespace Deliverable3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display array of 25 elements:");
            Console.WriteLine("_________________________________________"); //Add horizontal line
            Console.WriteLine("");//Add empty line

            //Assign number of elements
            int number_of_elements = 25;

            // Automatically populate an array with a number of elements
            int[] element = new int [number_of_elements];

            // Iterate through the array using a For Loop
            for (int i = 1; i <= number_of_elements; i++)
            {
                Console.WriteLine("Element value = " + i);
            }//End of For

            Console.WriteLine("");//Add empty line
            Console.WriteLine("_________________________________________");//Add horizontal line

            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }//End of Main
    }//End of Class
}//End of namespace
