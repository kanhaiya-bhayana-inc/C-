using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Two : Program
    {
        // Case 2: Accessing members of a class from child class of same project
        static void Main()
        {
            Two t = new Two();
            t.Foo2();
            t.Foo3();
            t.Foo4();
            t.Foo5();
        }
    }
}
