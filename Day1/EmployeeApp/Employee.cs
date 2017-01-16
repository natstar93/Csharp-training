using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
	class Employee
	{
		public string name;
		public int age;

		static int employeeID = 0;

		//constructor
		public Employee()
		{
			Console.WriteLine("Inside constructor");

			employeeID++;
		}

		//destructor
		~Employee()
		{
			Console.WriteLine("Inside destructor");
		}
		public void DisplayDetails()
		{
			Console.WriteLine("Employee's name is {0}", name);
			Console.WriteLine("Employee's age is {0}", age);
			Console.WriteLine("Employee ID is {0}", employeeID);
		}
	}
}
