using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello! ! ! ");
            TechSupport tech = new TechSupport(25.50, 1);
            tech.ITCheck("15.03");

            Console.ReadKey();
        }
    }
}
