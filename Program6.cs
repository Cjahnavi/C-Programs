using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    class Program
    {
        public void Test() //{ }
     //   static void Main(string[] args)
        {
            Console.WriteLine("Calling parents Test Method");
        }


    }

    //Here when we are trying to inherit the sealed class it is restricting to be inherited in child class.
    class Program1: Program
        {
        public new void Test()
        {
            Console.WriteLine("Calling child test method");
        }
        static void Main()
        {
            Program1 obj = new Program1();
            obj.Test();
            Console.ReadLine();

        }
    
    }
}
