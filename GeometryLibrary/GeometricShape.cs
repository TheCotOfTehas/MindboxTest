using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    //Класс который описывает геометрическую фигуру
    public abstract class GeometricShape
    {
        //метод который естьь но переопределять не обязательно, он будет по дефолту
        public virtual string GetName()
        {
            return "Shape: not Name";
        }
        //Абстракный метод который нужно переопределить в наследуемом классе
        public abstract double GetArea();
    }
}
