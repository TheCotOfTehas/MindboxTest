using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeometryLibrary.GeometricOperation;

namespace GeometryLibrary
{
    /// <summary>
    /// Описание фигуры прямоугольник
    /// </summary>
    public class Rectangle : CreatorGeometricShape
    {
        //Можно задать прямоугольник по разному. Стартовая верхняя левая точка (координаты)
        //и ширина, высота. Тут думаю нужно уточнить что от меня хотят. Для вычесления то что есть достаточно
        public double Side1 { get; }
        public double Side2 { get; }

        public Rectangle(double side1, double side2)
        {
            if (side1 <= 0)
                throw new ArgumentException("side not be less zero", nameof(side1));

            if (side2 <= 0)
                throw new ArgumentException("side not be less zero", nameof(side2));

            this.Side1 = side1;
            this.Side2 = side2;

            NameShape = "Rectangle";
        }

        public override double GetArea()
        {
            return GetAreaRectangle(Side1, Side2);
        }

        public override string GetName()
        {
            return "Rectangle";
        }
        public override string ToString()
        {
            return String.Format("Rectangle with whatrons {0} ond {1}", Side1, Side2);
        }
    }
}
