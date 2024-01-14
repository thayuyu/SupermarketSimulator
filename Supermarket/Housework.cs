using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Housework : Services, IService
    {

        private string address { get; set; }
        private string date { get; set; }
        // Constructor 
        public Housework(double Price, int Amount, string Address, string Date) : base(Price, Amount)
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);
            address = Address;
            date = Date;
        }

        public override string Output()
        {
            return $"Housework will be done {date} at address {address}. \nPrice: {GetPrice()} CHF\nPersonal needed: {GetAmountOfPersonal()}";
        }
    }
}
