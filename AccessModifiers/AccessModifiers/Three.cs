using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Three
    {
        // Case 3: Accessing members of a class from non-child class of same project
        static void Main() {
            Program p = new Program();
            p.Foo3();
            p.Foo4();
            p.Foo5();
        }
    }
}
