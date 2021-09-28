using NUnit.Framework;
using Task1;

namespace Task1Tests
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
            Assert.AreEqual("Camera", Program.GetName());
        }
    }
}