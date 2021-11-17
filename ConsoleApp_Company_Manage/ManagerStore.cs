using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    class ManagerStore : Employee
    {
        public int NumOfContract { get; set; }
        public ManagerStore(string name = "", string id = "", string birthDay = "", string dayToWork = "", uint numberWork = 0,
             decimal salaryperDay = 0, int numOfContract = 0) : base(name, id, birthDay, dayToWork, numberWork, salaryperDay)
        {
            try
            {
                NumOfContract = numOfContract;
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
                Console.Write("Enter the number of contract signed: ");
                NumOfContract = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Number of contract: " + NumOfContract);
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
            Salary = Salaryperday * NumberWork + NumberWork * 40;
            return Salary;
        }
        public static implicit operator ManagerStore(Accountant acc)
        {
            ManagerStore manager = new ManagerStore();
            manager.Name = acc.Name;
            manager.ID = acc.ID;
            manager.NumberWork = acc.NumberWork;
            manager.Salaryperday = acc.Salaryperday;
            manager.BirthDay = acc.BirthDay;
            manager.DaytoWork = acc.DaytoWork;
            manager.NumOfContract = 0;
            manager.CalculateSalary();
            return manager;
        }
        
    }
}
