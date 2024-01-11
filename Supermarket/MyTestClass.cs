using Supermarket;
using NUnit.Framework;

namespace Supermarket
{
    [TestFixture]
    public class TestMathHandler
    {
        //Tests for Articles
        [Test]
        public void TestArticleName()
        {
            //arrange
            Food myFood = new Food("Apple", 3.50, "16.01.2024", "fruit");
            //act
            myFood.SetName("Banana");
            //assert
            Assert.Equals(myFood.GetName(), "Banana");
        }

        [Test]
        public void TestArticlePrice()
        {
            //arrange
            Electronics myElectronic = new Electronics("Tastatur", 69.95, "Razer");
            //act
            myElectronic.SetProductPrice(85.00);
            //assert
            Assert.Equals(myElectronic.GetProductPrice(), 85.00);
        }

        [Test]
        public void TestElectronicManufacturer()
        {
            //arrange
            Electronics myElectronic = new Electronics("Tastatur", 69.95, "Razer");
            //act
            myElectronic.SetManufacturer("Asus");
            //assert
            Assert.Equals(myElectronic.GetManufacturer(), "Asus");
        }

        [Test]
        public void TestFoodExpiryDate()
        {
            //arrange
            Food myFood = new Food("Apple", 3.50, "17.08.2024", "fruit");
            //act
            myFood.SetExpiryDate("14.05.2023");
            //assert
            Assert.Equals(myFood.GetExpiryDate(), "14.05.2023");
        }

        [Test]
        public void TestFoodType()
        {
            //arrange
            Food myFood = new Food("Beef", 3.50, "17.08.2024", "fruit");
            //act
            myFood.SetFoodType("meat");
            //assert
            Assert.Equals(myFood.GetFoodType(), "meat");
        }


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

