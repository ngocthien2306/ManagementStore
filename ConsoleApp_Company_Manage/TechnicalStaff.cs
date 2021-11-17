using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class TechnicalStaff : Employee
    {
        public int NumberFixProduct { get; set; }
        public TechnicalStaff(string name = "", string id = "", string birthDay = "", string dayToWork = "", uint numberWork = 0,
             decimal salaryperDay = 0, int numberFixProduct = 0) : base(name, id, birthDay, dayToWork, numberWork, salaryperDay)
        {
            try
            {
                NumberFixProduct = numberFixProduct;
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
                Console.Write("Enter the number of products to be repaired: ");
                NumberFixProduct = Convert.ToInt32(Console.ReadLine());
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
                Console.Write("\nRepaired product: " + NumberFixProduct);
                Console.Write("\nSalary: " + Salary + " $ ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public override decimal CalculateSalary()
        {
            Salary = Salaryperday * (decimal)NumberWork + (decimal)NumberFixProduct * (decimal)1.2;
            return Salary;
        }
    }
}
