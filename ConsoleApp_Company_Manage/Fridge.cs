using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class Fridge : Product
    {
        private double powerConsumption = 0;
        private double capacity = 0;
        public double PowerConsumption
        {
            get { return powerConsumption; }
            set { if (0 < value) powerConsumption = value; }
        }
        public double Capacity
        {
            get { return capacity; }
            set { if (0 < value) capacity = value; }
        }
        public Fridge(string id = "", string name = "", string color = "", string brand = "", string madeIn = "", string warranty = "", uint amount = 0, decimal capital = 0, decimal profit = 0,
            double powerConsumption = 0, double capacity = 0) : base(id, name, color, brand, madeIn, warranty, amount, capital, profit)
        {
            try
            {
                PowerConsumption = powerConsumption;
                Capacity = capacity;
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
                Console.Write("\nEnter the power consumtion of fridge: ");
                PowerConsumption = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter the capacity of fridge: ");
                Capacity = Convert.ToDouble(Console.ReadLine());
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
                Console.Write("\nPower: " + PowerConsumption);
                Console.Write("\nCapacity: " + Capacity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
