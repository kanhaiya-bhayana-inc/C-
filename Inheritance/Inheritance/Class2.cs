using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   
       
    
    internal class Class2 : Program
    {
        public void Foo3()
        {
            Console.WriteLine("Called Foo3 -> Class2.Foo3");
        }
        public static void Main(string[] args)
        {
            Class2 cl = new Class2();
            cl.Foo1();
            cl.Foo2();
            cl.Foo3();
        }
    }

    
}
