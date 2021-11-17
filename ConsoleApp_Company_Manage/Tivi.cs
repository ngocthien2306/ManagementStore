using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class Tivi : Product
    {
        protected double size = 0;
        public double Size
        {
            get { return size; }
            set { if (value > 0) size = value; }
        }
        public string ScreenTechnology { get; set; }
        public Tivi(string id = "", string name = "", string color = "", string brand = "", string madeIn = "", string warranty = "", uint amount = 0, decimal capital = 0, decimal profit = 0,
            int size = 0, string screenTechnology = "") : base(id, name, color, brand, madeIn, warranty, amount, capital, profit)
        {
            try
            {
                Size = size;
                ScreenTechnology = screenTechnology;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override void Input()
        {
            base.Input();
            try
            {
                Console.Write("\nEnter screen technical of tivi: ");
                ScreenTechnology = Console.ReadLine();
                Console.Write("\nEnter the size of tivi: ");
                Size = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public override void Output()
        {
            base.Output();
            try
            {
                Console.Write("\nScreen technical: " + ScreenTechnology);
                Console.Write("\nSize: " + Size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
