using Xunit;
using Point = LinearInterpolation.Point;

namespace InterpolationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Point[] points = {new Point(1, 1), new Point(3, 3), new Point(4, 4), new Point(5, 5)};  
            var InterpolatedFunction = LinearInterpolation.Interpolation.GetInterpolation(points);

            Assert.Equal(2, InterpolatedFunction(2));
        }
    }
}
