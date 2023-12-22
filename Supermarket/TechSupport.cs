using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class TechSupport : Services
    {

        // Constructor 
        public TechSupport(double Price, int Amount) : base(Price, Amount)
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);
        }

        // general It check
        public void ITCheck(string date)
        {
            Console.WriteLine("A general check will be done the {0}", date);
        }
        //public void Maintenance(Electronics Item, int hours)
        //{
        //    Console.WriteLine("The Article {0} will undergo Maintenance for {1} hours and {2} will be needed for it.", Item.name, hours, GetAmountOfPersonal());
        //}
    }
}
