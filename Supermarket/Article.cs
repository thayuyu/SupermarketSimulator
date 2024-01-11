using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Article : IArticle
    {
        private double productPrice { get; set; }
        private string name { get; set; }

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
        public Article(string name, double price)
        {
            SetName(name);
            SetProductPrice(price);
        }
    }
}