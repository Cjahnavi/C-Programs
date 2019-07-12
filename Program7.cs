using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionToSealed
{
     class Program
    {
        public void Test() //{ }
                           //   static void Main(string[] args)
        {
            Console.WriteLine("Calling parents Test Method");
        }

        public virtual void Show() 
        {
            Console.WriteLine("Calling show Method");
        }

    }

    //Here when we are trying to inherit the sealed class it is restricting to be inherited in child class.
    class Program1 : Program
    {
        public new void Test()
        {
            Console.WriteLine("Calling child test method");
        }
        public sealed override void Show() //using seald in this method is restricting in below child class
        {
            Console.WriteLine("Calling Program1 show Method");
        }
    }

    class Program2 : Program1 {

        public  override void Show()
        {
            Console.WriteLine("Calling Program2 show Method");
        }
            static void Main()
        {
            Program2 obj = new Program2();
            obj.Test();
            obj.Show();
            Console.ReadLine();

        }
    }

    }
