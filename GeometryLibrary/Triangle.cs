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
    public class Triangle : GeometricShape
    {
        private  readonly double side1;
        private readonly double side2;
        private readonly double side3;
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

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double GetArea()
        {
            return GetAreaTriangle(side1, side2, side3);
        }
    }
}
