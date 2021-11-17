using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class CellPhone : Product
    {
        protected int rom = 0;
        public int Rom
        {
            get { return rom; }
            set { if (0 < value) rom = value; }
        }
        protected int ram = 0;
        public int Ram
        {
            get { return ram; }
            set { if (0 < value) ram = value; }
        }
        public string Chip { get; set; }
        protected int pin = 0;
        public int Pin
        {
            get { return pin; }
            set { if (value > 0) pin = value; }
        }
        protected double screenSize = 0;
        public double ScreenSize
        {
            get { return screenSize; }
            set { if (value > 0) screenSize = value; }
        }
        public CellPhone(string id = "", string name = "", string color = "", string brand = "", string madeIn = "", string warranty = "", uint amount = 0, decimal capital = 0, decimal profit = 0,
            int rom = 0, int ram = 0, string chip = "", int pin = 0, double screenSize = 0) : base(id, name, color, brand, madeIn, warranty, amount, capital, profit)
        {
            try
            {
                Rom = rom;
                Ram = ram;
                Chip = chip;
                Pin = pin;
                ScreenSize = screenSize;
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
                Console.Write("\nEnter the menory of the phone: ");
                Rom = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the ram of the phone: ");
                Ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter size of screen of the phone: ");
                ScreenSize = Convert.ToDouble(Console.ReadLine());
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
                Console.Write("\nMemory: " + Rom);
                Console.Write("\nRam: " + Ram);
                Console.Write("\nRom: " + Rom);
                Console.Write("\nChip: " + Chip);
                Console.Write("\nPin: " + Pin);
                Console.Write("\nSize: " + ScreenSize);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
