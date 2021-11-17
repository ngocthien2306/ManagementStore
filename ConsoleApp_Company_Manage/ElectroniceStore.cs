using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp_Company_Manage
{
    static class ElectroniceStore
    {
        public static string NameStore = "";
		public static string Address = "";
		public static List<Product> Products = new List<Product>();
		public static List<Employee> Employees = new List<Employee>();
        public static void InputEmployee()
        {
			Console.Write("\n\t\t\t\t\tThe name of electronic store: ");
			NameStore = Console.ReadLine();
			Console.Write("\n\t\t\t\t\tThe address of electronic store: ");
			Address = Console.ReadLine();
			int choice;
			do
			{
				Console.Write("\n\n\n\t\t\t\t\t\t-------EMPLOYEES-------\n");
				Console.Write("\n\t\t\t\t\t| ***   1. Add a manager           *** |\n");
				Console.Write("\n\t\t\t\t\t| ***   2. Add a technical staff   *** |\n");
				Console.Write("\n\t\t\t\t\t| ***   3. Add an accountant       *** |\n");
				Console.Write("\n\t\t\t\t\t| ***   4. Add a security guard    *** |\n");
				Console.Write("\n\t\t\t\t\t| ***   5. Add a salesman          *** |\n");
				Console.Write("\n\t\t\t\t\t| ***   6. Exit                    *** |\n");
				Console.Write("\n\t\t\t\t\tEnter your choice: ");
				choice = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				Employee employee;
				switch (choice)
				{
					case 1:
						employee = new ManagerStore();
						Console.Write("\nEnter the information of manager\n");
						employee.Input();
						Employees.Add(employee);
						break;
					case 2:
						employee = new TechnicalStaff();
						Console.Write("\nEnter the information of technical employee\n");
						employee.Input();
						Employees.Add(employee);
						break;
					case 3:
						employee = new Accountant();
						Console.Write("\nEnter the information of accountant employee\n");
						employee.Input();
						Employees.Add(employee);
						break;
					case 4:
						employee = new GuardingStaff();
						Console.Write("\nEnter the information of guarding employee\n");
						employee.Input();
						Employees.Add(employee);
						break;
					case 5:
						employee = new SalesAssistant();
						Console.Write("\nEnter the information of saleman \n");
						employee.Input();
						Employees.Add(employee);
						break;
					case 6:
						break;
					default:
						Console.Write("\nYour choice is ERROR! Please choice again!\n");
						break;
				}
			} while (choice != 6);
		}
		public static void InputProduct()
		{
			Console.Write("\n\t\t\t\t\tThe name of electronic store: ");
			NameStore = Console.ReadLine();
			Console.Write("\n\t\t\t\t\tThe address of electronic store: ");
			Address = Console.ReadLine();
			int choice;
			do
			{
				Console.Write("\n\n\n\t\t\t\t\t\t******PRODUCTS******\n");
				Console.Write("\n\t\t\t\t\t[   ----  1. Add a tivi     ----   ]\n");
				Console.Write("\n\t\t\t\t\t[   ----  2. Add a phone    ----   ]\n");
				Console.Write("\n\t\t\t\t\t[   ----  3. Add a laptop   ----   ]\n");
				Console.Write("\n\t\t\t\t\t[   ----  4. Add a fridge   ----   ]\n");
				Console.Write("\n\t\t\t\t\t[   ----  5. Exit!          ----   ]\n");
				Console.Write("\n\t\t\t\t\tEnter your choice: ");
				choice = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				Product product;
				switch (choice)
				{
					case 1:
						product = new Tivi();
						Console.Write("\nEnter the information of tivi \n");
						product.Input();
						Products.Add(product);
						break;
					case 2:
						product = new CellPhone();
						Console.Write("\nEnter the information of phone \n");
						product.Input();
						Products.Add(product);
						break;
					case 3:
						product = new Laptop();
						Console.Write("\nEnter the information of latop \n");
						product.Input();
						Products.Add(product);
						break;
					case 4:
						product = new Fridge();
						Console.Write("\nEnter the information of fridge \n");
						product.Input();
						Products.Add(product);
						break;
					case 5:
						break;
					default:
						Console.Write("\nYour choice is ERROR! please choice again! \n");
						break;
				}
			} while (choice != 5);
		}
		public static void OutputEmployee()
		{
			Console.Write("\nList of employees \n");
			for (int i = 0; i < Employees.Count; i++)
			{
				Console.WriteLine("\nThe information of employee " + (i + 1));
				Employees[i].Output();
				Console.WriteLine();
			}
			Console.Write("\nSum all salary of employee: " + TotalSalary());
		}
		public static decimal TotalSalary()
		{
			decimal sume = 0;
			int n = Employees.Count;
			for (int i = 0; i < n; i++)
			{
				sume = sume + Employees[i].Salary;
			}
			return sume;
		}
		public static void OutputProduct()
		{
			Console.Write("\nList of products\n");
			for (int i = 0; i < Products.Count; i++)
			{
				Console.Write("\nThe information of product " + (i + 1));
				Products[i].Output();
				Console.WriteLine();
			}
			Console.WriteLine("Totall product capital: " + TotalProductCapital().ToString());
			Console.WriteLine("Totall product price: " + TotalProductPrice().ToString());
		}
		public static decimal TotalProductCapital()
        {
			decimal sum = 0;
            for (int i = 0; i < Products.Count; i++)
            {
				sum += (Products[i].Capital * (decimal)Products[i].Amount);
            }
			return sum;
        }
		public static decimal TotalProductPrice()
		{
			decimal sum = 0;
			for (int i = 0; i < Products.Count; i++)
			{
				sum += (Products[i].Price * (decimal)Products[i].Amount);
			}
			return sum;
		}
		public static void Display()
		{
			Console.WriteLine("\nName store: " + NameStore);
			Console.WriteLine("\nStore Adress: " + Address);
			int choice;
			do
			{
				Console.WriteLine("\n\n\n\t\t\t\t\t\t------DISPLAY LIST------\n");
				Console.WriteLine("\n\t\t\t\t\t[] ----- 1. Dislplay list employee -----[] \n");
				Console.WriteLine("\n\t\t\t\t\t[] ----- 2. Dislplay list product  -----[] \n");
				Console.WriteLine("\n\t\t\t\t\t[] ----- 3. Dislplay both          -----[] \n");
				Console.WriteLine("\n\t\t\t\t\t[] ----- 4. Exit!                  -----[] \n");
				Console.Write("\n\t\t\t\t\tEnter your choice: ");
				choice = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				switch (choice)
				{
					case 1:
						OutputEmployee();
						break;
					case 2:
						OutputProduct();
						break;
					case 3:
						Console.WriteLine("\nList employee \n");
						OutputEmployee();
						Console.WriteLine("\nList product \n");
						OutputProduct();
						break;
					case 4:
						break;
					default:
						Console.WriteLine("\nYour choice is ERROR. Please choice again!");
						break;
				}
			} while (choice != 4);
		}
		public static void SearchNameProduct()
		{
			string NameSearch;
			Console.Write("\nEnter the name prodcut you want to find: ");
			NameSearch = Console.ReadLine();
			var products = from product in Products
						   where product.Name.CompareTo(NameSearch) == 0
					       select product;
            if (products.Count() > 0)
            {
				Console.WriteLine("Result: ");
				foreach (var a in products)
				{
					a.Output();
				}
            }
            else
            {
				Console.WriteLine("Can not find out!");
			}
		}
		public static void SearchNameEmployee()
		{
			string NameSearch;
			Console.Write("\nEnter the name of employee you want to search: ");
			NameSearch = Console.ReadLine();
			var employees = from employee in Employees
						   where employee.Name.CompareTo(NameSearch) == 0
						   select employee;
			if (employees.Count() > 0)
			{
				Console.WriteLine("Result: ");
				foreach (var a in employees)
				{
					a.Output();
				}
			}
			else
			{
				Console.WriteLine("Can not find out!");
			}
			Employees.AddRange(employees);
		}
		public static void RemoveProduct()
		{
			Console.Write("\nEnter the ID you want to remove in list product: ");
			string id = Console.ReadLine();

			Products = Products.Where(x => x.ID.CompareTo(id) != 0).ToList();

			Display();
		}
		public static void RemoveEmployee()
		{
			Console.Write("\nEnter the ID you want to remove in list employee: ");
			string id = Console.ReadLine();
			
			Employees = Employees.Where(x => x.ID.CompareTo(id) != 0).ToList();

			Display();
		}
		public static void EditProduct()
        {
			Console.Write("\nEnter the ID you want to edit in list product: ");
			string id = Console.ReadLine();
			var products = from product in Products
						   where product.ID.CompareTo(id) == 0
						   select product;
            foreach (var product in products)
            {
				product.Input();
            }
			Products.AddRange(products.ToList());
		}
		public static void EditEmployee()
		{
			Console.Write("\nEnter the ID you want to edit in list Employee: ");
			string id = Console.ReadLine();
			var employees = from employee in Employees
							where employee.ID.CompareTo(id) == 0
							select employee;
			foreach (var employee in employees)
			{
				employee.Input();
			}
			Employees.AddRange(employees);
		}
		public static void SortingPriceProduct()
		{
			Products = Products.OrderByDescending(x => x.Price).ToList();
			Display();
		}
		public static void SortingSalaryEmployee()
        {
			Employees = Employees.OrderByDescending(x => x.Salary).ToList();
			Display();
		}
		public static void PromoteAcountantToManager()
        {
			Console.Write("\nEnter the ID of accountant to promote to manager: ");
			string id = Console.ReadLine();

			var accountants = from acc in Employees
							where acc.ID.CompareTo(id) == 0
							select acc;
			if (accountants.Count() > 0)
			{
				Console.WriteLine("Result: ");
				foreach (var a in accountants)
				{
					Employees = Employees.Where(x => x.ID.CompareTo(id) != 0).ToList();
					Accountant acc = new Accountant();
					acc.Name = a.Name;
					acc.ID = a.ID;
					acc.NumberWork = a.NumberWork;
					acc.Salaryperday = a.Salaryperday;
					acc.CalculateSalary();
					Employees.Add((ManagerStore)acc);
				}
			}
			else
			{
				Console.WriteLine("Can not find out!");
			}
		}
		public static void IncreaseSalary()
        {
			Console.Write("\nEnter the ID of employee to increase: ");
			string id = Console.ReadLine();
			Console.WriteLine("Input the monney you want to increase: ");
			decimal monney = Convert.ToDecimal(Console.ReadLine());
			var employees = from employee in Employees
							where employee.ID.CompareTo(id) == 0
							select employee;
			foreach (var employee in employees)
			{
				employee.Salaryperday += monney;
			}
		}
	}
}
