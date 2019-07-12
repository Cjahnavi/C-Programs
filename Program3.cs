using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

namespace ColorsAssignmnt
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> My_array = new List<string>();

            // Adding elements in the  
            // My_array ArrayList 
            // This ArrayList contains  
            // elements of the same types 
            My_array.Add("Red");
            My_array.Add("Blue");
            My_array.Add("White");
            My_array.Add("Green");
            My_array.Add("Yelow");

            
            foreach(string array in My_array)
            {
                Console.WriteLine(array);
            }
            My_array.Reverse(1, 2);
            Console.WriteLine("After");
            foreach (string array in My_array)
            {
                Console.WriteLine(array);
            }
            Console.ReadKey();


        }

        
    }
}
