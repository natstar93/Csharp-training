using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter length of rectangle in cm");

			int length = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine();

			Console.WriteLine("Enter width of rectangle in cm");

			int width = Convert.ToInt16(Console.ReadLine());

			Rectangle rectangle = new Rectangle(length, width);

			Console.WriteLine();

			Console.WriteLine("Area is {0}cm^2", rectangle.CalculateArea());

			Console.WriteLine();

			Console.WriteLine("Perimeter is {0}cm", rectangle.CalculatePerimeter());

			Console.ReadKey();

		}
	}
}
