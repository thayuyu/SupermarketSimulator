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

            List<IArticle> mDynamicArticleArray = tech.GetArticleList();
            foreach (IArticle myArtiecle in mDynamicArticleArray) 
            {
                string myArticleName = myArtiecle.GetName();
                Console.WriteLine(myArticleName);
            }

            Console.ReadKey();
        }
    }
}
