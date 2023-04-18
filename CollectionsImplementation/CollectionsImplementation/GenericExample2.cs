using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsImplementation
{
    // Creating class as a generic...
    internal class GenericExample2<T>
    {
        public void Add(T a, T b)
        { 
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine( d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mult(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
    class TestGeneric
    {
        static void Main()
        {
            GenericExample2<int> genericExample2 = new GenericExample2<int>();
            genericExample2.Add(19, 29);
            genericExample2.Sub(19, 29);
            genericExample2.Mult(19, 29);
            genericExample2.Div(19, 29);
        }
    }
}
