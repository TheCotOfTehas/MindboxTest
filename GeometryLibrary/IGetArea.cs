using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    //Это метод который должен иметь любая фигура в нашем случае выислить площадь
    //Можно добавить допустим получить периметр или получить количество вершин.
    //Была пометка "Вычисление площади фигуры без знания типа фигуры в compile-time"
    //Все фигуры имеют такой метод и можно получить площадь так как будут реализовывать этот интерфейс
    internal interface IGetArea
    {
        public double GetArea();
    }
}
