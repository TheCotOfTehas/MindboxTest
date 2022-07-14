using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeometryLibrary.GeometricOperation;


namespace GeometryLibrary
{
    /// <summary>
    /// Описание фигуры круг
    /// </summary>
    public class Circle : GeometricShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("radius not be less zero", nameof(radius));

            this.radius = radius;
        }

        public override double GetArea()
        {
            return GetAreaCircle(radius);
        }

        public override string GetName()
        {
            return "Circle";
        }
        public override string ToString()
        {
            return String.Format("Circle with radius {0}", radius);
        }
    }
}
