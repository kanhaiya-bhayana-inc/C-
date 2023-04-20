using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    interface IShape
    {
        double GetArea();
    }

    class Circle : IShape
    {
        public double radius { get; set; }
        public Circle(double r)
        {
            radius = r;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : IShape
    {
        public double length { get; set; }
        public double breadth { get; set; }

        public double GetArea()
        {
            return length * breadth;
        }
    }
}
