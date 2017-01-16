using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Employee app";

			Employee employee1 = new Employee();

			employee1.name = "Natstar";
			employee1.age = 32;

			Console.WriteLine("Employee 1 details");

			employee1.DisplayDetails();

			employee1 = null;

			System.GC.Collect();

			Console.WriteLine();

			Employee employee2 = new Employee()
			{
				name = "Dusky",
                age = 30
			};

			Console.WriteLine("Employee 2 details");

			employee2.DisplayDetails();

			Console.ReadKey();
		}
	}
}
