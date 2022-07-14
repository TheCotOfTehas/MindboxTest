using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;
namespace TestProjectGeometry
{
    public class UnitTestCircle
    {
        [Fact]
        public void GetArea_Circle_Zero_side()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Circle(0);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Circle(-8);
            });
        }

        [Fact]
        public void GetArea_Circle()
        {
            var circle = new Circle(10);
            Assert.Equal(314.159, circle.GetArea());
        }

    }
}
