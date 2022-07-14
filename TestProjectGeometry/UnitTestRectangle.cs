using GeometryLibrary;

namespace TestProjectGeometry
{
    public class UnitTestRectangle
    {
        [Fact]
        public void GetArea_Rectangle()
        {
            var rectangle = new Rectangle(5, 6);
            Assert.Equal(30, rectangle.GetArea());
        }

        [Fact]
        public void GetArea_Rectangle_Zero_side()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Rectangle(0, 6);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Rectangle(5, 0);
            });
        }

        [Fact]
        public void GetArea_Rectangle_LessZero_side()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Rectangle(1, -4);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var rectangle = new Rectangle(-1, 5);
            });
        }
    }
}