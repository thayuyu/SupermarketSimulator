using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Housework : Services
    {


        // Constructor 
        public Housework(double Price, int Amount) : base(Price, Amount) 
        {
            SetPrice(Price);
            SetAmountPersonal(Amount);

        }

        // Cleaning a client's house
        public void CleanHouse(string address, string date, double Price)
        {
            SetPrice(Price);
            Console.WriteLine("The {0}, the House at {1} will be cleaned for {2:0.00} CHF", date, address, GetPrice());
        }

        // Changing a light bulb !!just for testing!!
        public void ChangeBulb()
        {
            Console.WriteLine("You really need help with that?");
        }
    }
}
