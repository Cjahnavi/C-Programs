
using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static public void Main()
        {

            // Creating ArrayList 
           ArrayList My_array = new ArrayList();

            // Adding elements in the  
            // My_array ArrayList 
            // This ArrayList contains elements 
            // of different types 
            My_array.Add(12.56);
            My_array.Add("GeeksforGeeks");
            My_array.Add(null);
            My_array.Add('G');
            My_array.Add(1234);
            My_array.Add('R');
            My_array.Add('G');
            My_array.Add('E');
            My_array.Add('E');
            My_array.Add('K');
            My_array.Add('S');


            // Accessing the elements  
            // of My_array ArrayList 
            // Using foreach loop 
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine("Number of elements: " + My_array.Count);
            Console.WriteLine("Number of elements: " + My_array.Capacity);
            My_array.Remove('G');
            Console.WriteLine("After Remove() method the " +
                  "number of elements: " + My_array.Count);
            My_array.RemoveAt(8);
            Console.WriteLine("After RemoveAt() method the " +
                    "number of elements: " + My_array.Count);
            My_array.RemoveRange(1, 3);
            Console.WriteLine("After RemoveRange() method the" +
                     " number of elements: " + My_array.Count);
            My_array.Clear();
            Console.WriteLine("After Clear() method the " +
                "number of elements: " + My_array.Count);
            Console.ReadKey();
        }
    }
}
