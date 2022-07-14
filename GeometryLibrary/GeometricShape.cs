using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    //Класс для создания геометрическую фигуру
    //Его можно расширить в зависимости от нееобходимости
    //Я просто не знаю что ещё добавить. С другой стороны лишнего лучше не придумывать
    //Не знаю можно ли это назвать Factory Method -я читал патерн такой есть.
    //Это к пометке "Легкость добавления других фигур"
    public abstract class CreatorGeometricShape : IGetArea
    {
        //По умолчанию будет "Имя не присвоено";
        public string NameShape { get; set; } = "Имя не присвоено";
        //метод который естьь но переопределять не обязательно, он будет по дефолту
        public virtual string GetName()
        {
            return "Shape: not Name";
        }
        //Абстракный метод который нужно переопределить в наследуемом классе
        public abstract double GetArea();
    }
}
