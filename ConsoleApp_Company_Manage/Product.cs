using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_Company_Manage
{
    abstract class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string MadeIn { get; set; }
        private decimal capital = 0;
        public decimal Capital
        {
            get { return capital; }
            set
            {
                if(value > 0)
                {
                    capital = value;
                    Price = Capital + Profit;
                }
            }
        }
        private decimal profit = 0;
        public decimal Profit
        {
            get { return profit; }
            set
            {
                if (value > 0)
                {
                    profit = value;
                    Price = Capital + Profit;
                }
            }
        }
        public decimal Price { get; protected set; }
        public string Warranty { get; set; }
        protected uint amount = 0;
        public uint Amount
        {
            get { return amount; }
            set
            {
                if (0 <= value)
                {
                    amount = value;
                }
            }
        }
        public string Color { get; set; }
        public Product(string id = "", string name = "", string color = "", string brand = "", 
            string madeIn = "", string warranty = "", uint amount = 0, decimal capital = 0, decimal profit = 0)
        {
            try
            {
                ID = id;
                Name = name;
                Color = color;
                Brand = brand;
                MadeIn = madeIn;
                Warranty = warranty;
                Amount = amount;
                Capital = capital;
                Profit = profit;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public virtual void Input()
        {
            try
            {
                Console.Write("\nEnter name product: ");
                Name= Console.ReadLine();
                Console.Write("\nEnter ID of the product: ");
                ID = Console.ReadLine();
                Console.Write("\nEnter color: ");
                Color = Console.ReadLine();
                Console.Write("\nEnter place productivity: ");
                MadeIn = Console.ReadLine();
                Console.Write("\nEnter brand: ");
                Brand = Console.ReadLine();
                Console.Write("\nEnter the warranty period (y-mm): ");
                Warranty = Console.ReadLine();
                Console.Write("\nCapital of product: ");
                Capital = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nProfit of product: ");
                Profit = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nAmount of product: ");
                Amount = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public virtual void Output()
        {
            try
            {
                Console.Write("\nName: " + Name);
                Console.Write("\nID: " + ID);
                Console.Write("\nColor: " + Color);
                Console.Write("\nMAde in: " + MadeIn);
                Console.Write("\nBrand: " + Brand);
                Console.Write("\nCapital: " + Capital);
                Console.Write("\nProfit: " + Profit);
                Console.Write("\nPrice: " + Price);
                Console.Write("\nWarranty: " + Warranty);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
