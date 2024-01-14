using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class TechSupport : Services, IService
    {

        private string date { get; set; }
        private Electronics item { get; set; }

        // Constructor 
        public TechSupport(double Price, int Amount, string Date, Electronics Item) : base(Price, Amount)
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);
            date = Date;
            item = Item;
        }
        public override string Output()
        {
            if (item == null)
            {
                return $"The {date}, Tech Support will be done.\nPrice: {GetPrice()} CHF\nPersonal needed: {GetAmountOfPersonal()}";
            }
            else
            {
                return $"The {date}, Tech Support for the article {item.GetName()} from Maufacturer {item.GetManufacturer()} will be done.\nPrice: {GetPrice()} CHF\nPersonal needed: {GetAmountOfPersonal()}";
            }
        }
    }
}
