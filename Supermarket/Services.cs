using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Services
    {
        // Memebervariables
        private double price;
        private int amountOfPersonal;
        
        // Constructor
        public Services(double Price, int Amount) 
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);
        }

        // Get/Set Functions
        public void SetPrice(double Price)
        {
            price = Price;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetAmountPersonal(int amount) 
        {
            amountOfPersonal = amount;
        }
        public int GetAmountOfPersonal()
        {
            return amountOfPersonal;
        }

        // Adding specific amount of Personal after creating the object
        public void AddPersonal(int value)
        {
            amountOfPersonal += value;
        }
    }
}
