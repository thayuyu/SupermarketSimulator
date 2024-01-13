using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Article : IArticle
    {
        private double productPrice { get; set; }
        private string name { get; set; }

        List<IArticle> myArticleList = new List<IArticle>();

        public Article(string name, double price)
        {
            SetName(name);
            SetProductPrice(price);
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string valuename)
        {
            name = valuename;
        }
        public double GetProductPrice()
        {
            return productPrice;
        }
        public void SetProductPrice(double valueprice)
        {
            productPrice = valueprice;
        }


        public List<IArticle> GetArticleList()
        {
            return myArticleList;
        }

        public void AddArticle(bool IsElectronic, string name, double price, string manufacturer, string expiryDate, string foodType)
        {
            if(IsElectronic)
            {
                Electronics NewElectronic = new Electronics(name, price, manufacturer);
                myArticleList.Add(NewElectronic);
            }
            else
            {
                Food NewFood = new Food(name, price, expiryDate, foodType);
                myArticleList.Add(NewFood);


            }
        }
    }
}