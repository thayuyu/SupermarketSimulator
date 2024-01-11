using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Food : Article
    {
        private string expiryDate { get; set; }
        private string foodType { get; set; }

        public string GetExpiryDate()
        {
            return expiryDate;
        }
        public void SetExpiryDate(string valueExpiryDate)
        {
            expiryDate = valueExpiryDate;
        }
        public string GetFoodType()
        {
            return foodType;
        }
        public void SetFoodType(string valueFoodType)
        {
            foodType = valueFoodType;
        }

        //Konstruktor
        public Food(string name, double price, string expiryDate, string foodType) : base(name, price)
        {
            SetExpiryDate(expiryDate);
            SetFoodType(foodType);
        }
        public Food(string name, double price) : base(name, price)
        {
        }
    }
}
