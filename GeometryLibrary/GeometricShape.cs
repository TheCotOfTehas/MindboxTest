using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public abstract class GeometricShape
    {
        public virtual string GetName()
        {
            return "Shape: not Name";
        }
        public abstract double GetArea();
    }
}
