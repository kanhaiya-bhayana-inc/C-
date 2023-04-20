using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class Printer
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape);
        }
    }
}
