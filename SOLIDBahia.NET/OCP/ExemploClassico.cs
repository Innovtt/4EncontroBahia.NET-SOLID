using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDBahia.NET.OCP
{
    public class RectangleV1
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculatorV1
    {
        public double Area(RectangleV1[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;

                //if (shape is Rectangle)
                //{
                //    Rectangle rectangle = (Rectangle)shape;
                //    area += rectangle.Width * rectangle.Height;
                //}
                //else
                //{
                //    Circle circle = (Circle)shape;
                //    area += circle.Radius * circle.Radius * Math.PI;
                //}

            }

            return area;
        }
    }



    public abstract class Shape
    {
        public abstract double Area();
    }

    public class RectangleV2 : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public class AreaCalculatorV2
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
