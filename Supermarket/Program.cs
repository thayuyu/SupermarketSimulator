using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Services service = new Services(0.0, 1);
            Article article = new Article("", 0.00);
            List<IArticle> myArticleArray = article.GetArticleList();
            List<IService> myList = service.GetServiceList();


            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("List of products [1]" +
                    "\nAdd a product [2]" +
                    "\nHousework [3]" +
                    "\nTech Support [4]" +
                    "\nShow services [5]" +
                    "\nGet Receipt [6]" +
                    "\n\nEnd program [0]");

                if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                    Console.Clear();
                    if (choice == 0)
                    {
                        Console.WriteLine("Ending program...");
                        break;
                    }

                    //List
                    else if (choice == 1)
                    {
                        Console.WriteLine("What kind of list of products do you want?");
                        Console.WriteLine("Electronics [1]" +
                            "\nFood [2]" +
                            "\nBoth [3]" +
                            "\n\nGo back [0]");
                        if(int.TryParse(Console.ReadLine(), out int choiceList))
                        {
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
                                    "\nAll three [4]" +
                                    "\n\nGo back [0]");
                                if(int.TryParse(Console.ReadLine(), out int choiceListArticle))
                                {
                                    ListElectronics(choiceListArticle, myArticleArray);
                                }
                                else
                                {
                                    Console.WriteLine("Your input was not a number!");
                                    Console.ReadKey();
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
                                    "\nAll four [5]" +
                                    "\n\n Go back [0]");
                                if(int.TryParse(Console.ReadLine(), out int choiceListArticle))
                                {
                                    ListFood(choiceListArticle, myArticleArray);
                                }
                                else
                                {
                                    Console.WriteLine("Your input was not a number!");
                                    Console.ReadKey();
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
                                if (int.TryParse(Console.ReadLine(), out int choiceListArticle))
                                {

                                    if (choiceListArticle == 0)
                                    {
                                    }
                                    else if (choiceListArticle == 1)
                                    {
                                        WriteAllArticleFieldsFromList(typeof(IArticle), myArticleArray, true, false, false, false, false);
                                    }
                                    else if (choiceListArticle == 2)
                                    {
                                        WriteAllArticleFieldsFromList(typeof(IArticle), myArticleArray, false, true, false, false, false);
                                    }
                                    else if (choiceListArticle == 3)
                                    {
                                        WriteAllArticleFieldsFromList(typeof(IArticle), myArticleArray, true, true, false, false, false);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You have chosen a number that offers nothing.");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Your input was not a number!");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You have not chosen a possible number!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your input was not a number!");
                            Console.ReadKey();
                        }

                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("What kind of product do you want to add?");
                        Console.WriteLine("Electronic [1]" +
                            "\nFood [2]" +
                            "\n\nGo back [0]");
                        if(int.TryParse(Console.ReadLine(), out int choiceAddProduct))
                        {
                            AddArticle(choiceAddProduct, article);
                        }
                        else
                        {
                            Console.WriteLine("Your input was not a number!");
                            Console.ReadKey();
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("How much does it cost?");
                        if (int.TryParse(Console.ReadLine(), out int price))
                        {
                            Console.WriteLine("How many people are needed?");
                            if (int.TryParse(Console.ReadLine(), out int amountOfPers))
                            {
                                Console.WriteLine("Where will it be done?");
                                string address = Console.ReadLine();
                                Console.WriteLine("When should the Housework be done?");
                                string date = Console.ReadLine();

                                service.AddService(true, price, amountOfPers, address, date, null);
                            }
                            else
                            {
                                Console.WriteLine("Your input was not a number!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your input was not a number!");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("How much does it cost?");
                        if (int.TryParse(Console.ReadLine(), out int price))
                        {
                            Console.WriteLine("How many people are needed?");
                            if(int.TryParse(Console.ReadLine(), out int amountOfPers))
                            {
                                Console.WriteLine("When will the TechSupport be done?");
                                string date = Console.ReadLine();
                                Console.WriteLine("What's the name of the product you'd like to fix?");
                                Electronics item = FindElectronic(Console.ReadLine(), myArticleArray);


                                service.AddService(false, price, amountOfPers, null, date, item);
                            }
                            else
                            {
                                Console.WriteLine("Your input was not a number!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            {
                                Console.WriteLine("Your input was not a number!");
                                Console.ReadKey();
                            }
                        }
                        Console.Clear();
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("What do you want to show?" +
                            "\nHousework [1]" +
                            "\nTechSupport [2]" +
                            "\nBoth [3]" +
                            "\n\nGo Back [0]");
                        if (int.TryParse(Console.ReadLine(), out int choiceChooseServiceList))
                        {
                            if (choiceChooseServiceList == 0)
                            {

                            }
                            else if (choiceChooseServiceList == 1)
                            {
                                Console.WriteLine("All Housework saved:\n");
                                foreach (Housework s in myList)
                                {
                                    Console.WriteLine(s.Output());
                                    Console.Write("\n");

                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (choiceChooseServiceList == 2)
                            {
                                Console.WriteLine("All Tech Support saved:\n");
                                foreach (TechSupport s in myList)
                                {
                                    Console.WriteLine(s.Output());
                                    Console.Write("\n");
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (choiceChooseServiceList == 3)
                            {
                                Console.WriteLine("All Services saved:\n");
                                foreach (IService s in myList)
                                {
                                    Console.WriteLine(s.Output());
                                    Console.Write("\n");
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You have chosen a number that is not available");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your input was not a number!");
                        }
                    }
                    else if (choice == 6)
                    {
                        double subTotalArti = 0.0;
                        double subTotalServ = 0.0;
                        Console.Clear();
                        Console.WriteLine("Here is your receipt:\n\nArticles:\n");
                        foreach (Article a in myArticleArray)
                        {
                            Console.WriteLine($"{a.GetName()}\t\t\t{a.GetProductPrice()}\n");
                            subTotalArti += a.GetProductPrice();
                        }
                        Console.WriteLine($"\n\tSubtotal Articles:\t\t{subTotalArti}");
                        Console.WriteLine("\n\nServices:\n");
                        foreach (Services s in myList)
                        {
                            Console.WriteLine($"{s.Output()}\n");
                            subTotalServ += s.GetPrice();
                        }
                        Console.WriteLine($"\n\tSubtotal Services:\t\t{subTotalServ}");

                        Console.WriteLine($"\n\n\nTotal:\t\t\t{subTotalArti + subTotalServ}");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You have not chosen one of the possible numbers!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Your input was not a number!");
                    Console.ReadKey();
                }
                Console.Clear();


            } while (ProgramLoop == true);

            Console.WriteLine();
            Console.ReadKey();
        }

        private static void WriteAllArticleFieldsFromList(Type filterTyp,List<IArticle> myArticleArray, bool writeName, bool writePrice, bool writeManufacturer, bool writeExpiryDate, bool writeFoodType)
        {
            foreach (IArticle myArticle in myArticleArray)
            {
                Type articleType = myArticle.GetType();

                if (filterTyp == typeof(IArticle) || articleType == filterTyp)
                {
                    if (writeName)
                    {
                        string myArticleName = myArticle.GetName();
                        Console.WriteLine("Name: {0}", myArticleName);
                    }
                    if (writePrice)
                    {
                        string myArticlePrice = Convert.ToString(myArticle.GetProductPrice());
                        Console.WriteLine("Price: {0}", myArticlePrice);
                    }
                    if (writeManufacturer)
                    {
                        string myArticleManufacturer = ((Electronics)myArticle).GetManufacturer();
                        Console.WriteLine("Manufacturer: {0}", myArticleManufacturer);
                    }
                    if (writeExpiryDate)
                    {
                        string myArticleExpiryDate = ((Food)myArticle).GetExpiryDate();
                        Console.WriteLine("Expiry date: {0}", myArticleExpiryDate);
                    }
                    if (writeFoodType)
                    {
                        string myArticleFoodType = ((Food)myArticle).GetFoodType();
                        Console.WriteLine("Food type: {0}", myArticleFoodType);
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }

        private static void ListElectronics(int choiceListArticle, List<IArticle> myArticleArray)
        {
            if (choiceListArticle == 0)
            {
            }
            else if (choiceListArticle == 1)
            {
                WriteAllArticleFieldsFromList(typeof(Electronics), myArticleArray, true, false, false, false, false);
            }
            else if (choiceListArticle == 2)
            {
                WriteAllArticleFieldsFromList(typeof(Electronics), myArticleArray, false, true, false, false, false);
            }
            else if (choiceListArticle == 3)
            {
                WriteAllArticleFieldsFromList(typeof(Electronics), myArticleArray, false, false, true, false, false);
            }
            else if(choiceListArticle == 4)
            {
                WriteAllArticleFieldsFromList(typeof(Electronics), myArticleArray, true, true, true, false, false);
            }
            else
            {
                Console.WriteLine("Error, You have chosen a number that is not available.");
                Console.ReadKey();
            }
            Console.Clear();
        }

        private static void ListFood(int choiceListArticle, List<IArticle> myArticleArray)
        {
            if (choiceListArticle == 0)
            {
                Console.Clear();
            }
            else if (choiceListArticle == 1)
            {
                WriteAllArticleFieldsFromList(typeof(Food), myArticleArray, true, false, false, false, false);
            }
            else if (choiceListArticle == 2)
            {
                WriteAllArticleFieldsFromList(typeof(Food), myArticleArray, false, true, false, false, false);
            }
            else if (choiceListArticle == 3)
            {
                WriteAllArticleFieldsFromList(typeof(Food), myArticleArray, false, false, false, true, false);
            }
            else if (choiceListArticle == 4)
            {
                WriteAllArticleFieldsFromList(typeof(Food), myArticleArray, false, false, false, false, true);
            }
            else if (choiceListArticle == 5)
            {
                WriteAllArticleFieldsFromList(typeof(Food), myArticleArray, true, true, false, true, true);
            }
            else
            {
                Console.WriteLine("Error, You have chosen a number that is not available.");
                Console.ReadKey();
            }
            Console.Clear();
        }

        private static void AddArticle(int choiceAddProduct, Article article)
        {
            if (choiceAddProduct == 0)
            {
                Console.Clear();
            }
            else if (choiceAddProduct == 1)
            {
                AddProduct(article, true);
            }
            else if (choiceAddProduct == 2)
            {
                AddProduct(article, false);
            }
            else
            {
                Console.WriteLine("Error, you have chosen a number that is not available.");
                Console.ReadKey();
            }
        }
        private static void AddProduct(Article article, bool IsElectronic)
        {
            string Productname;
            string Productmanufacturer;
            string ProductExpirydate;
            string ProductFoodType;
            if (IsElectronic)
            {
                Console.WriteLine("What is the products name?");
                Productname = Console.ReadLine();
                Console.WriteLine("What is the products price?");
                if(int.TryParse(Console.ReadLine(), out int Productprice))
                {
                    Console.WriteLine("Who is the manufacturer of the product?");
                    Productmanufacturer = Console.ReadLine();

                    if (Productname == null || Productprice == 0.00 || Productmanufacturer == null)
                    {
                        Console.WriteLine("Error, at least one field was left empty.");
                        Console.ReadKey();
                    }
                    else
                    {
                        article.AddArticle(true, Productname, Productprice, Productmanufacturer, "", "");
                    }
                }
                else
                {
                    Console.WriteLine("Your input was not a number!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("What is the products name?");
                Productname = Console.ReadLine();
                Console.WriteLine("What is the products price?");
                if (int.TryParse(Console.ReadLine(), out int Productprice))
                {
                    Console.WriteLine("When does the product expire?");
                    ProductExpirydate = Console.ReadLine();
                    Console.WriteLine("What type of food is it? (vegetable, meat...)");
                    ProductFoodType = Console.ReadLine();

                    if (Productname == null || Productprice == 0.00 || ProductExpirydate == null || ProductFoodType == null)
                    {
                        Console.WriteLine("Error, at least one field was left empty.");
                        Console.ReadKey();
                    }
                    else
                    {
                        article.AddArticle(false, Productname, Productprice, "", ProductExpirydate, ProductFoodType);
                    }
                }
                else
                {
                    Console.WriteLine("Your input was not a number!");
                    Console.ReadKey();
                }

            }
            Console.Clear();

        }
        static public Electronics FindElectronic(string name, List<IArticle> List)
        {
            foreach (Electronics E in List)
            {
                if (E.GetName() == name)
                {
                    return E;
                }
            }
            return null;
        }
    }
}
