using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Services : IService
    {
        // Memebervariables
        private double price;
        private int amountOfPersonal;

        List<IService> myServicesList = new List<IService>();

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
        public List<IService> GetServiceList()
        {
            return myServicesList;
        }

        public void AddService(bool IsHousework, double Price, int Amount, string Address, string Date, Electronics Item)
        {
            if (IsHousework)
            {
                Housework NewHouseWork = new Housework(Price, Amount, Address, Date);
                myServicesList.Add(NewHouseWork);
            }
            else
            {
                TechSupport NewTechSupport = new TechSupport(Price, Amount, Date, Item);
                myServicesList.Add(NewTechSupport);
            }
        }
        public virtual string Output()
        {
            return "error";
        }
    }
}
