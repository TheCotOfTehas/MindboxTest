using GeometryLibrary;

namespace TestProjectGeometry
{
    public class UnitTestTriangle
    {
        [Fact]
        public void GetArea_Triangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea());
        }

        [Fact]
        public void GetArea_Triangle_Zero_side()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Triangle(0, 4, 5);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Triangle(5, 0 , 4);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Triangle(5, 4, 0);
            });
        }

        [Fact]
        public void GetArea_Triangle_LessZero_side()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Triangle(3, -4, 5);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Triangle(-3, 4, 5);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Triangle(3, 4, -5);
            });
        }

        [Fact]
        public void Create_Wrong_Triangle()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var rectangle = new Triangle(1, 2, 4);
            });

            Assert.Throws<InvalidOperationException>(() =>
            {
                var rectangle = new Triangle(1, 2, 3);
            });
        }
    }
}
