using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    // Interface Always implements in the base class and does not create ambiguity
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();

    }
    internal class ImplementMultipleInheritance : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Called Test method under child class.");
        }

        void Interface1.Show() { Console.WriteLine("Called Interface1.Show"); }
        void Interface2.Show() { Console.WriteLine("Called Interface2.Show");  }

        static void Main()
        {
            ImplementMultipleInheritance obj = new ImplementMultipleInheritance();
            obj.Test();
            Interface1 obj1 = obj; obj1.Show();  // here we created a reference of Interface1 and explicitly called the Show method
            Interface2 obj2 = obj; obj2.Show();
        }
    }
}
