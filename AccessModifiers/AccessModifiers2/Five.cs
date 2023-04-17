using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    internal class Five
    {
        // Case 5: Accessing members of a class from non-child class of different project
        static void Main(string[] args)
        {
            AccessModifiers.Program p = new AccessModifiers.Program();
            p.Foo3();
            
        }
    }
}
