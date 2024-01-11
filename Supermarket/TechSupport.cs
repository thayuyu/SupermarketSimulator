using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class TechSupport : Services
    {

        // private List<Electronics> Items = new List<Electronics> ();
        // Constructor 
        public TechSupport(double Price, int Amount) : base(Price, Amount)
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);
        }

        public List<IArticle> GetArticleList()
        {
            List <IArticle> mArticleList = new List<IArticle> ();
            IArticle mySampleFood = new Food("Rindsfilet", 0, "01.01.2023", "Fleisch");
            Electronics mySampleElectronic = new Electronics("PC", 0);
            mArticleList.Add(mySampleFood);
            mArticleList.Add(mySampleElectronic);

            return mArticleList;
        }

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
