using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
	class Program
	{
		static void Main(string[] args)
		{
			//change title
			Console.Title = "Operator example app";

			//create an instance of Operators. specify type Operators (classname name = constructor)
			Operators opera = new Operators();

			//call the arithmetic method
			opera.Arithmetic();

			Console.WriteLine();

			opera.Relational();

			Console.WriteLine();

			opera.Logical(true, false); // positional argument

			opera.Logical(b: false, a: false); // named argument

			opera.Assignment(2, 3);

			Console.ReadKey();
		}
	}
}
