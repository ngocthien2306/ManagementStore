using System;

namespace ConsoleApp_Company_Manage
{
    class GuardingStaff : Employee
    {
        protected string[] shifts = new string[]
        {
            "Shift 1: 7AM - 11AM",
            "Shift 2: 1PM - 5PM",
            "Shift 3: 5PM - 9PM"
        };
        public string ShiftWork { get; protected set; }
        public GuardingStaff(string name = "", string id = "", string birthDay = "", string dayToWork = "", uint numberWork = 0,
             decimal salaryperDay = 0, int shiftWork = 0) : base(name, id, birthDay, dayToWork, numberWork, salaryperDay)
        {
            try
            {
                ShiftWork = shifts[shiftWork - 1];
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
                Console.WriteLine("Enter number of shift day ");
                for (int i = 0; i < shifts.Length; i++)
                {
                    Console.WriteLine('\t' + shifts[i]);
                }
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
                Console.WriteLine(ShiftWork);
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
            Salary = Salaryperday * NumberWork;
            return Salary;
        }
    }
}
