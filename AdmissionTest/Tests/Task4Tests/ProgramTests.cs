using NUnit.Framework;
using Task4;

namespace Task4Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var point1 = new Point { X = 5, Y = 9 };
            var point2 = point1;

            point2.X = 3;

            Assert.AreNotEqual(point1.X, point2.X);
        }
    }
}