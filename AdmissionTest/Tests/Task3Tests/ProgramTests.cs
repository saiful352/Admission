using NUnit.Framework;
using Task3;

namespace Task3Tests
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
            var lines = Program.GetLines();
            Assert.AreEqual("Hello World From C#", lines[0]);
            Assert.AreEqual("This is a demo text for admission test.", lines[1]);
            Assert.AreEqual("Please do not change this text.", lines[2]);
        }
    }
}