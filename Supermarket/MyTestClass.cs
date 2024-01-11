using Supermarket;
using NUnit.Framework;

namespace Supermarket
{
    [TestFixture]
    public class TestMathHandler
    {
   
        [Test]
        public void TestServices()
        {
            //arrange
            TechSupport myService = new TechSupport(0, 0);
            //act
            myService.SetPrice(10);
            //assert
            Assert.Equals(myService.GetPrice(), 10);
        }
    }
}

