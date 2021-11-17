using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string BirthDay { get; set; }
        public string DaytoWork { get; set; }
        public uint NumberWork { get; set; }
        public decimal Salaryperday { get; set; }
        public decimal Salary { get; protected set; }

        public Employee(string name = "", string id = "", string birthDay = "", string dayToWork = "", uint numberWork = 0,
             decimal salaryperDay = 0)
        {
            try
            {
                Name = name;
                ID = id;
                BirthDay = birthDay;
                DaytoWork = dayToWork;
                NumberWork = numberWork;
                Salaryperday = salaryperDay;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public virtual void Input()
        {
            try
            {
                Console.Write("Enter name: ");
                Name = Console.ReadLine();
                Console.Write("Enter ID: ");
                ID = Console.ReadLine();
                Console.Write("Enter your birth day (dd/mm/yyyy): ");
                BirthDay = Console.ReadLine();
                Console.Write("Enter the day begin to work (dd//mm/yyyy): ");
                DaytoWork = Console.ReadLine();
                Console.Write("Enter number of work: ");
                NumberWork = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Enter salary perday ($): ");
                Salaryperday = Convert.ToDecimal(Console.ReadLine());
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
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Birth day: " + BirthDay);
                Console.WriteLine("Day to work: " + DaytoWork);
                Console.WriteLine("Number of work: " + NumberWork);
                Console.WriteLine("Salary perday: " + Salaryperday);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public abstract decimal CalculateSalary();
    }
}
