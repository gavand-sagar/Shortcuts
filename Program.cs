using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shortcuts
{
    public class Product
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public void InitializeFromConsole()
        {
            ProductName = SagarUtilities.GetStringFromUser("Enter Product Name");
            Brand = SagarUtilities.GetStringFromUser("Enter Brand Name");
            Price = SagarUtilities.GetDoubleFromUser("Enter Price");
        }
    }

    public class Mobile
    {
        public string MobileBrand { get; set; }
        public string MobileName { get; set; }
        public double MobilePrice { get; set; }


    }

    static class DataHolder
    {
        private static List<Mobile> mobiles = new List<Mobile>();
        private static void Add(Mobile mobile)
        {
            mobiles.Add(mobile);
        }
        public static IEnumerable<Mobile> GetMobiles() { return mobiles.AsEnumerable(); }
    }

    public class Program
    {

        static Dictionary<string, Product> productsDictionary = new Dictionary<string, Product>();

        static Product Search(Product p)
        {



            return null;
        }



        static void Main(string[] args)
        {

            Navigator.Navigate("Main");


            Console.ReadLine();

        }


        static void KuchKar(IFather father)
        {
            father.EntertainChild();
        }

        private static void DisplayMobileList(List<Mobile> mobiles)
        {
            Console.Clear();
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Name", "Brand", "Price");
            Console.WriteLine("==================================");
            foreach (var item in mobiles)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}", item.MobileName, item.MobileBrand, item.MobilePrice);
            }
        }

        private static List<Mobile> ConvertProductListToMobile(List<Product> products)
        {
            List<Mobile> mobiles = new List<Mobile>();

            foreach (var product in products)
            {
                Mobile mobile = new Mobile();
                mobile.MobileBrand = product.Brand;
                mobile.MobileName = product.ProductName;
                mobile.MobilePrice = product.Price;
                mobiles.Add(mobile);
            }

            return mobiles;
        }

        private static List<Product> GetProductsFromUser()
        {
            List<Product> products = new List<Product>();
            do
            {
                Product product = new Product();

                product.InitializeFromConsole();

                products.Add(product);

                Console.WriteLine("Do you want to add new? (enter to continue | 'n' to stop)");

            } while (Console.ReadLine().ToLower() != "n");

            return products;
        }


    }



}
