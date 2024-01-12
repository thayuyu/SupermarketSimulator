using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class TechSupport : Services
    {
        List<IArticle> mArticleList = new List<IArticle>();


        // private List<Electronics> Items = new List<Electronics> ();
        // Constructor 
        public TechSupport(double Price, int Amount) : base(Price, Amount)
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);
        }

        //public List<IArticle> GetArticleList()
        //{
        //    return mArticleList;
        //}

        //public void AddArticle(bool IsElectronic, string name, double price, string manufacturer, string expiryDate, string foodType)
        //{
        //    if(IsElectronic)
        //    {
        //        Electronics NewElectronic = new Electronics(name, price, manufacturer);
        //        mArticleList.Add(NewElectronic);
        //    }
        //    else if (!IsElectronic)
        //    {
        //        Food NewFood = new Food(name, price, expiryDate, foodType);
        //        mArticleList.Add(NewFood);
        //    }
        //}

        // general It check
        public void ITCheck(string date)
        {
            Console.WriteLine("A general check will be done the {0}", date);
        }
        //public void Maintenance(Electronics Item, int hours)
        //{
        //    Console.WriteLine("The Article {0} will undergo Maintenance for {1} hours and {2} will be needed for it.\nPrice:{3}", Item.name, hours, GetAmountOfPersonal(), GetPrice());
        //}
    }
}
