using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class GeometricOperation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lengtSide1">Длинна первой стороны прямоугольника</param>
        /// <param name="lengtSide2">Длинна второй стороны прямоугольника</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Сторона не может быть меньше или равной нулю</exception>
        public static double GetAreaRectangle(double lengtSide1, double lengtSide2)
        {
            if (lengtSide1 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide1));

            if (lengtSide2 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide2));

            return lengtSide1 * lengtSide2;
        }

        public static double GetAreaTriangle(double lengtSide1, double lengtSide2)
        {
            if (lengtSide1 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide1));

            if (lengtSide2 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide2));

            return lengtSide1 * lengtSide2;
        }

        public static double GetAreaCircle(double lengtSide1, double lengtSide2, double lengtSide3)
        {
            if (lengtSide1 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide1));

            if (lengtSide2 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide2));

            if (lengtSide3 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide3));

            var halfPerimeter = (lengtSide1 + lengtSide2 + lengtSide3) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - lengtSide1) * (halfPerimeter - lengtSide2) * (halfPerimeter - lengtSide3));
        }
    }
}
