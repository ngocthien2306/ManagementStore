using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class SalesAssistant : Employee
    {
        public int NumOfProductSold { get; set; }
        public SalesAssistant(string name = "", string id = "", string birthDay = "", string dayToWork = "", uint numberWork = 0,
             decimal salaryperDay = 0, int numOfProductSold = 0) : base(name, id, birthDay, dayToWork, numberWork, salaryperDay)
        {
            try
            {
                NumOfProductSold = numOfProductSold;
                CalculateSalary();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public override void Input()
        {
            base.Input();
            try
            {
                Console.Write("Enter the number of product was saled: ");
                NumOfProductSold = Convert.ToInt32(Console.ReadLine());
                CalculateSalary();
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
                Console.WriteLine("Product saled: " + NumOfProductSold);
                Console.WriteLine("Salary: " + Salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public override decimal CalculateSalary()
        {
            Salary = NumberWork * Salaryperday + NumOfProductSold * (3);
            return Salary;
        }
    }
}
