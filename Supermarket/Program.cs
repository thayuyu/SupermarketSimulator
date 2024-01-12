using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramLoop = true;
            int choice;
            int choiceList;
            int choiceAddProduct;
            Console.WriteLine("hello! ! ! ");
            TechSupport tech = new TechSupport(25.50, 1);
            Article article = new Article();
            List<IArticle> myArticleArray = article.GetArticleList();
            tech.ITCheck("15.03");

            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("List of products [1]" +
                    "\nAdd a product [2]" +
                    "\nCheck in Service [3]" +
                    "\nReserve housework [4]" +
                    "\n\nEnd program [0]");

                choice = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if(choice == 0)
                {
                    Console.WriteLine("Ending program...");
                    ProgramLoop = false;
                    break;
                }
                else if(choice == 1)
                {
                    Console.WriteLine("What kind of list of products do you want?");
                    Console.WriteLine("Electronics [1]" +
                        "\nFood [2]" +
                        "\nBoth [3]" +
                        "\n\nGo back [0]");
                    choiceList = Convert.ToInt16(Console.ReadLine());
                    if (choiceList == 0)
                    {
                        Console.Clear();
                    }
                    else if (choiceList == 1)
                    {
                        //foreach...
                    }
                    else if (choiceList == 2)
                    {
                        //foreach...
                    }
                    else if (choiceList == 3)
                    {
                        foreach (IArticle myArtiecle in myArticleArray)
                        {
                            string myArticleName = myArtiecle.GetName();
                            Console.WriteLine(myArticleName);
                        }
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("What kind of product do you want to add?");
                    Console.WriteLine("Electronic [1]" +
                        "\nFood [2]" +
                        "\n\nGo back [0]");
                    choiceAddProduct = Convert.ToInt16(Console.ReadLine());
                    if(choiceAddProduct == 0)
                    {
                        Console.Clear();
                    }
                    else if (choiceAddProduct == 1)
                    {
                        Console.WriteLine("What is the products name?");

                        Console.WriteLine("What is the products price?");

                        Console.WriteLine("Who is the manufacturer of the product?");
                    }
                    else if(choiceAddProduct == 2)
                    {
                        Console.WriteLine("What is the products name?");

                        Console.WriteLine("What is the products price?");

                        Console.WriteLine("When does the product expire?");

                        Console.WriteLine("What type of food is it? (vegetable, meat...)");
                    }
                }
                else if (choice == 3)
                {




                }
                else if (choice == 4)
                {

                }
            } while (ProgramLoop == true);

            Console.ReadKey();
        }
    }
}
