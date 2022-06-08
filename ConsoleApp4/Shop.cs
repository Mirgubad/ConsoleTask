using System;

namespace ConsoleApp4
{
    public class Shop
    {
        public int TotalIncome { get; set; }

        public Object[] products;


        public Shop()
        {
            products = new object[0];

            string ask;
        flag1:
            Console.WriteLine("1.Add Product  2.Sell Product ");
            ask = Console.ReadLine();

            if (ask == "1")
            {

                Console.WriteLine("Name of product:");
                string name = Console.ReadLine();
                Console.WriteLine("Price:");
                string price = Console.ReadLine();
                double dprice = double.Parse(price);
                Console.WriteLine("Count:");
                string count = Console.ReadLine();
                int countpr = int.Parse(count);
                Console.WriteLine("Product type");
                string prtype = Console.ReadLine();

                if (prtype == "c")
                {
                    Cofee cofee = new Cofee(name, countpr, dprice);
                    if (ProductAdd(cofee))
                    {
                        Console.WriteLine("Cofee is added");
                    }
                    else
                    {
                        Console.WriteLine("Cofe isnt added");
                    }
                }
                else if (prtype == "t")
                {
                    Tea tea = new Tea(name, countpr, dprice);
                    if (ProductAdd(tea))
                    {
                        Console.WriteLine("Tea is added");
                        Show(products);
                    }
                    else
                    {
                        Console.WriteLine("Tea isnt added");
                    }
                }
                goto flag1;
            }
            if (ask == "2")
            {
                Console.WriteLine("Selling product:");
                string name = Console.ReadLine();
                Console.WriteLine("Count:");
                string count = Console.ReadLine();
                int countpr = int.Parse(count);
            }
        }
        public bool ProductAdd(Object obj)

        {
            string type = obj.GetType().Name;
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = obj;

            return true;
        }
        public void SellProduct()
        {
            Array.Resize(ref products, products.Length - 1);
        }
        public void Show(object product)
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}





