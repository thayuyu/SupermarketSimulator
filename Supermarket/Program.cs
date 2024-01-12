using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramLoop = true;
            int choice;
            int choiceList;
            int choiceListArticle;
            int choiceAddProduct;
            Console.WriteLine("hello! ! ! ");
            TechSupport tech = new TechSupport(25.50, 1);
            Article article = new Article("Testarticle", 0.00);
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

                //List
                else if(choice == 1)
                {
                    Console.WriteLine("What kind of list of products do you want?");
                    Console.WriteLine("Electronics [1]" +
                        "\nFood [2]" +
                        "\nBoth [3]" +
                        "\n\nGo back [0]");
                    choiceList = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    if (choiceList == 0)
                    {
                        Console.Clear();
                    }

                    //Electronics
                    else if (choiceList == 1)
                    {
                        Console.WriteLine("What do you want to see listed?");
                        Console.WriteLine("Names [1]" +
                            "\nPrices [2]" +
                            "\nManufacturers [3]" +
                            "\n\nGo back [0]");
                        choiceListArticle = Convert.ToInt16(Console.ReadLine());
                        if (choiceListArticle == 0)
                        {
                            Console.Clear() ;
                        }
                        else if (choiceListArticle == 1)
                        {
                            //foreach getName Electronic
                        }
                        else if (choiceListArticle == 2)
                        {
                            //foreach getPrice Electronic
                        }
                        else if (choiceListArticle == 3)
                        {
                            //foreach getManufacturer Electronic
                        }
                        else
                        {
                            Console.WriteLine("Error, You have chosen a number that is not available.");
                        }
                    }

                    //Food
                    else if (choiceList == 2)
                    {
                        Console.WriteLine("What do you want to see listed?");
                        Console.WriteLine("Names [1]" +
                            "\nPrices [2]" +
                            "\nExpiry dates [3]" +
                            "\nFood types [4]" +
                            "\n\n Go back [0]");
                        choiceListArticle = Convert.ToInt16(Console.ReadLine());
                        if (choiceListArticle == 0)
                        {
                            Console.Clear();
                        }
                        else if (choiceListArticle == 1)
                        {
                            //foreach getName Food
                        }
                        else if (choiceListArticle == 2)
                        {
                            //foreach getPrice Food
                        }
                        else if (choiceListArticle == 3)
                        {
                            //foreach getExpiryDate Food
                        }
                        else if (choiceListArticle == 4)
                        {
                            //foreach getFoodType Food
                        }
                        else
                        {
                            Console.WriteLine("Error, You have chosen a number that is not available.");
                        }
                    }

                    //Both
                    else if (choiceList == 3)
                    {
                        Console.WriteLine("What do you want to see listed?");
                        Console.WriteLine("Names [1]" +
                            "\nPrices [2]" +
                            "\nBoth [3]" +
                            "\n\nGo back [0]");
                        choiceListArticle = Convert.ToInt16(Console.ReadLine());
                        if (choiceListArticle == 0)
                        {
                            Console.Clear();
                        }
                        else if (choiceListArticle == 1)
                        {
                            foreach (IArticle myArtiecle in myArticleArray)
                            {
                                string myArticleName = myArtiecle.GetName();
                                Console.WriteLine(myArticleName);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (choiceListArticle == 2)
                        {
                            foreach (IArticle myArticle in myArticleArray)
                            {
                                string myArticlePrice = Convert.ToString(myArticle.GetProductPrice());
                                Console.WriteLine(myArticlePrice);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (choiceListArticle == 3)
                        {
                            foreach (IArticle myArticle in myArticleArray)
                            {
                                string myArticleName = myArticle.GetName();
                                string myArticlePrice = Convert.ToString(myArticle.GetProductPrice());

                                Console.WriteLine("Name: {0}\tPrice: {1}\n", myArticleName, myArticlePrice);

                            }
                            Console.ReadKey();
                            Console.Clear();
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
                    string Productname;
                    double Productprice;
                    if (choiceAddProduct == 0)
                    {
                        Console.Clear();
                    }
                    else if (choiceAddProduct == 1)
                    {
                        Console.WriteLine("What is the products name?");
                        Productname = Console.ReadLine();
                        Console.WriteLine("What is the products price?");
                        Productprice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Who is the manufacturer of the product?");
                        string Productmanufacturer = Console.ReadLine();

                        article.AddArticle(true, Productname, Productprice, Productmanufacturer, "", "");
                        Console.Clear();
                    }
                    else if(choiceAddProduct == 2)
                    {
                        Console.WriteLine("What is the products name?");
                        Productname = Console.ReadLine();
                        Console.WriteLine("What is the products price?");
                        Productprice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("When does the product expire?");
                        string ProductExpirydate = Console.ReadLine();
                        Console.WriteLine("What type of food is it? (vegetable, meat...)");
                        string ProductFoodType = Console.ReadLine();

                        if (Productname == null || Productprice == 0.00 || ProductExpirydate == null || ProductFoodType == null)
                        {
                            Console.WriteLine("Error, at least one field was left empty.");
                            Console.ReadKey();
                        }
                        else
                        {
                            article.AddArticle(false, Productname, Productprice, "", ProductExpirydate, ProductFoodType);
                        }
                        Console.Clear();
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
