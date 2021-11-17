using System;
using System.IO;

namespace ConsoleApp_Company_Manage
{
    class Program
    {
		
        static void Main(string[] args)
        {
			int choice;
			do
			{
				Console.Write("\n\n\n\n\t\t\t\t\t        --------MENU--------");
				Console.Write("\n\n\t\t\t\t\t  |---   1. Add product       ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   2. Add employee      ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   3. Display           ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   4. Search list       ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   5. Edit information  ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   6. Remove list       ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   7. Sorting list      ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   8. Promote accountant---|");
				Console.Write("\n\n\t\t\t\t\t  |---   9. Increase Salary   ---|");
				Console.Write("\n\n\t\t\t\t\t  |---   10. Exit!            ---|");
				Console.Write("\n\n\t\t\t\t\t         Enter your choice: ");
				choice = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				switch (choice)
				{
					case 1:
						ElectroniceStore.InputProduct();
						break;
					case 2:
						ElectroniceStore.InputEmployee();
						break;
					case 3:
						ElectroniceStore.Display();
						break;
					case 4:
						int choice2;
						do
						{
							Console.Write("\n\n\n\t\t\t\t\t\t _-_-_-_ SEARCHING _-_-_-_ \n");
							Console.Write("\n\t\t\t\t\t [) ----  1. Search list employee  ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ----  2. Search list product   ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ----  3. Exit!.                ---- (]\n");
							Console.Write("\n\t\t\t\t\t Enter your choice: ");
							choice2 = Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							switch (choice2)
							{
								case 1:
									ElectroniceStore.SearchNameEmployee();
									break;
								case 2:
									ElectroniceStore.SearchNameProduct();
									break;
								case 3:
									break;
								default:
									Console.Write("\nYour choice is ERROR! Please choice again.");
									break;
							}
						} while (choice2 != 3);
						break;
					case 5:
						int choice5;
						do
						{
							Console.Write("\n\n\n\t\t\t\t\t\t _-_-_-_ EDIT LIST _-_-_-_ \n");
							Console.Write("\n\t\t\t\t\t [) ----  1. Edit list employee    ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ----  2. Edit list product     ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ----  3. Exit!.                ---- (]\n");
							Console.Write("\n\t\t\t\t\t Enter your choice: ");
							choice5 = Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							switch (choice5)
							{
								case 1:
									ElectroniceStore.EditEmployee();
									break;
								case 2:
									ElectroniceStore.EditProduct();
									break;
								case 3:
									break;
								default:
									Console.Write("\nYour choice is ERROR! Please choice again.");
									break;
							}
						} while (choice5 != 3);
						break;
					case 6:
						int choice3;
						do
						{
							Console.Write("\n\n\n\t\t\t\t\t\t _-_-_-_ REMOVING _-_-_-_ \n");
							Console.Write("\n\t\t\t\t\t [) ----  1. Remove list employee  ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ----  2. Remove list product   ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ----  3. Exit!.                ---- (]\n");
							Console.Write("\n\t\t\t\t\t Enter your choice: ");
							choice3 = Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							switch (choice3)
							{
								case 1:
									ElectroniceStore.RemoveEmployee();
									break;
								case 2:
									ElectroniceStore.RemoveProduct();
									break;
								case 3:
									break;
								default:
									Console.Write("\nYour choice is ERROR! Please choice again.");
									break;
							}
						} while (choice3 != 3);
						break;
					case 7:
						int choice4;
						do
						{
							Console.Write("\n\n\n\t\t\t\t\t\t_-_-_-_ SORTING _-_-_-_ \n");
							Console.Write("\n\t\t\t\t\t [) ---- 1. Sorting list employee ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ---- 2. Sorting list product  ---- (]\n");
							Console.Write("\n\t\t\t\t\t [) ---- 3. Exit!.                ---- (]\n");
							Console.Write("\n\t\t\t\t\t Enter your choice: ");
							choice4 = Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							switch (choice4)
							{
								case 1:
									ElectroniceStore.SortingSalaryEmployee();
									break;
								case 2:
									ElectroniceStore.SortingPriceProduct();
									break;
								case 3:
									break;
								default:
									Console.Write("\nYour choice is ERROR! Please choice again.");
									break;
							}
						} while (choice4 != 3);
						break;
					case 8:
						ElectroniceStore.PromoteAcountantToManager();
						break;
					case 9:
						ElectroniceStore.IncreaseSalary();
						break;
					default:
						Console.Write("\nThe your choice ERROR! Please choice again.");
						break;
				}

			} while (choice != 10);
		}
    }
}
