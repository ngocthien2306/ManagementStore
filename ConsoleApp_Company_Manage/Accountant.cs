using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class Accountant : Employee
    {
        public double Allowance { get; set; }
        public Accountant(string name = "", string id = "", string birthDay = "", string dayToWork = "", uint numberWork = 0,
             decimal salaryperDay = 0, double allowance = 1) : base(name, id, birthDay, dayToWork, numberWork, salaryperDay)
        {
            try
            {
                Allowance = allowance;
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
                Console.Write("Enter the allowance of the employee: ");
                Allowance = Convert.ToDouble(Console.ReadLine());
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
                Console.Write("Allwance: " + Allowance);
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
            Salary = NumberWork * Salaryperday + (decimal)Allowance;
            return Salary;
        }
    }
}
