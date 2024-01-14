using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Electronics : Article, IArticle
    {
        private string manufacturer { get; set; }

        public string GetManufacturer()
        {
            return manufacturer;
        }
        public void SetManufacturer(string value)
        {
            manufacturer = value;
        }

        //Konstruktor

        public Electronics(string name, double price, string manufacturer) : base(name, price)
        {
            SetManufacturer(manufacturer);
        }
        public Electronics(string name, double price) : base(name, price)
        {
        }
    }
}
