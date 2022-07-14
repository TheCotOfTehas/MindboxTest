using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeometryLibrary.GeometricOperation;

namespace GeometryLibrary
{
    /// <summary>
    /// Описание класса фигуры треугольник
    /// </summary>
    public class Triangle : CreatorGeometricShape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        public bool IsRightTriangle { get; }
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0)
                throw new ArgumentException("side not be less zero", nameof(side1));

            if (side2 <= 0)
                throw new ArgumentException("side not be less zero", nameof(side2));

            if (side3 <= 0)
                throw new ArgumentException("side not be less zero", nameof(side3));

            if (WrongTriangle(side1, side2, side3))
                throw new InvalidOperationException("WrongTriangle");

            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            IsRightTriangle = IsRightTriangle(side1, side2, side3);
            NameShape = "Triangle";
        }
        public override double GetArea()
        {
            return GetAreaTriangle(Side1, Side2, Side3);
        }
    }
}
