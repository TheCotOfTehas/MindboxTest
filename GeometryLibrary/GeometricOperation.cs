using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    /// <summary>
    /// Задание Напишите на C# библиотеку для поставки внешним клиентам,
    /// которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
    /// </summary>
    public class GeometricOperation
    {
        /// <summary>
        /// Получить площадь прямоугольника
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

        /// <summary>
        /// Получить площадь круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Радиус не может быть меньше или равной нулю</exception>
        public static double GetAreaCircle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("side not be less zero", nameof(radius));

            return Math.Round( Math.PI * radius * radius,  3);
        }

        /// <summary>
        /// Метод проверки треугольника на наличии прямого угла
        /// </summary>
        /// <param name="lengtSide1"></param>
        /// <param name="lengtSide2"></param>
        /// <param name="lengtSide3"></param>
        /// <returns></returns>
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            if (side1 * side1 == side2 * side2 + side3 * side3)
                return true;

            if (side2 * side2 == side1 * side1 + side3 * side3)
                return true;

            if (side3 * side3 == side1 * side1 + side2 * side2)
                return true;

            return false;
        }

        /// <summary>
        /// Получить площадь треугольника
        /// </summary>
        /// <param name="lengtSide1">Длинна первой стороны треугольника</param>
        /// <param name="lengtSide2">Длинна второй стороны треугольника</param>
        /// <param name="lengtSide3">Длинна третей стороны треугольника</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Сторона не может быть меньше или равной нулю</exception>
        /// <exception cref="InvalidOperationException">Невозмоно построить треугольник с такими сторонами</exception>
        public static double GetAreaTriangle(double lengtSide1, double lengtSide2, double lengtSide3)
        {
            if (lengtSide1 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide1));

            if (lengtSide2 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide2));

            if (lengtSide3 <= 0)
                throw new ArgumentException("side not be less zero", nameof(lengtSide3));

            //Я не знаю как правильно реагировать на такую ситуацию.
            //Возмножно в случаее когда площадь равна нулю это если длина 2х сторон
            //равна третей. В случаее когда сумма двух сторон меньше, третей треугольник нельзя построить. 
            if (WrongTriangle(lengtSide1, lengtSide2, lengtSide3))
                throw new InvalidOperationException("WrongTriangle");

            var halfPerimeter = (lengtSide1 + lengtSide2 + lengtSide3) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - lengtSide1) * (halfPerimeter - lengtSide2) * (halfPerimeter - lengtSide3));
        }

        //проверка на допустимость существования треугольника с предоставленными габаритами
        public static bool WrongTriangle(double lengtSide1, double lengtSide2, double lengtSide3)
        {
            if (lengtSide1 + lengtSide2 <= lengtSide3)
                return true;

            if (lengtSide2 + lengtSide3 <= lengtSide1)
                return true;

            if (lengtSide3 + lengtSide1 <= lengtSide2)
                return true;

            return false;
        }
    }
}
