using System.Reflection.Metadata.Ecma335;

namespace Abdtract_Implementation
{
    public abstract class Figures
    {
        public double height, width, radius;
        public const float pi = 3.14f;

        /*Abastract keyword restrict to define the body of the method, 
        you may define the implementation of the method by removing the abstract keyword....*/
        public abstract double GetArea();
    }

    class Rectangle : Figures
    {
        public Rectangle(double _height, double _width)
        {
            this.height = _height;
            this.width = _width;
        }
        public override double GetArea()
        {
            return height * width;
        }
    }

    class Circle : Figures
    {
        public Circle(double _radius)
        {
            this.radius = _radius;
        }

        public override double GetArea()
        {
            return pi * radius * radius;
        }

    }
        
    public class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);

            Console.WriteLine(r.GetArea());
            Console.WriteLine(c.GetArea());
        }
    }

}