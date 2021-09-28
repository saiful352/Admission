using NUnit.Framework;
using Task2;

namespace Task2Tests
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
            var item1 = new ProductFactory<ProductOne>().Create();
            Assert.AreEqual("Product 1", item1.Name);

            var item2 = new ProductFactory<ProductTwo>().Create();
            Assert.AreEqual("Product 2", item2.Name);
        }
    }
}