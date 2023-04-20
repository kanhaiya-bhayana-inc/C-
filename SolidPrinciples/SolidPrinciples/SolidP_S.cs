using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // *********************************************************************************

    // -------------------   S  ---------------
   
    // -------------------   O  ---------------
    /* Open-Closed Principle */

    /* A class should be open for extention but closed for modification */

    // *********************************************************************************

    
    
    internal class SolidP_S
    {
        public static void CalculateArea(IShape shape)
        {
            Console.WriteLine(shape.GetArea());
        }
        static void Main()
        {
            IShape cr = new Circle(5);
            IShape rec = new Rectangle { length = 5, breadth = 4 };
            CalculateArea(cr);
            CalculateArea(rec);
        }
    }
}
