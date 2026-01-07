using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_5_GIT_EXERCISE
{
    abstract class Shapes
    {
        public abstract string Name { get; }
        public abstract double getarea();

    }
    class circle : Shapes
    {
        double radius;
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override string Name => "circle";
        public override double getarea()
        {
            return 3.14 * radius * radius;
        }
    }
    class rectangle : Shapes
    {
        double length, width;
        public rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override string Name => "rectangle";
        public override double getarea()
        {
            return length * width;
        }
    }
    class triangle : Shapes
    {
        double b, h;
        public triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public override string Name => "triangle";
        public override double getarea()
        {
            return 0.5 * b * h;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shapes> shapes = new List<Shapes>();
            shapes.Add(new circle(3.5));
            shapes.Add(new rectangle(4.5, 5.4));
            shapes.Add(new triangle(1.2, 4.8));

            foreach (var shape in shapes)
            {
                Console.WriteLine($"the area of {shape.Name} is{shape.getarea()}\n");

            }
        }
    }
}
