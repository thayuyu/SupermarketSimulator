using Supermarket;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestSupermarket
{
    [TestFixture]
    public class TestArticle
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
            Assert.That(myFood.GetName(), Is.EqualTo("Banana"));
        }

        [Test]
        public void TestArticlePrice()
        {
            //arrange
            Electronics myElectronic = new Electronics("Tastatur", 69.95, "Razer");
            //act
            myElectronic.SetProductPrice(85.00);
            //assert
            Assert.That(myElectronic.GetProductPrice(), Is.EqualTo(85.00d));
        }

        [Test]
        public void TestElectronicManufacturer()
        {
            //arrange
            Electronics myElectronic = new Electronics("Tastatur", 69.95, "Razer");
            //act
            myElectronic.SetManufacturer("Asus");
            //assert
            Assert.That(myElectronic.GetManufacturer(), Is.EqualTo("Asus"));
        }

        [Test]
        public void TestFoodExpiryDate()
        {
            //arrange
            Food myFood = new Food("Apple", 3.50, "17.08.2024", "fruit");
            //act
            myFood.SetExpiryDate("14.05.2023");
            //assert
            Assert.That(myFood.GetExpiryDate(), Is.EqualTo("14.05.2023"));
        }

        [Test]
        public void TestFoodType()
        {
            //arrange
            Food myFood = new Food("Beef", 3.50, "17.08.2024", "fruit");
            //act
            myFood.SetFoodType("meat");
            //assert
            Assert.That(myFood.GetFoodType(), Is.EqualTo("meat"));
        }

        [Test]
        public void TestArticleList()
        {
            //arrange
            Article testarticle = new Article("", 0);
            //act
            testarticle.AddArticle(true, "TestArticleName", 0.00, "TestArticleManufacturer", "", "");
            List<IArticle> testList = testarticle.GetArticleList();
            //assert
            Assert.That(testList.Count, Is.EqualTo(1));
        }
    }
}

