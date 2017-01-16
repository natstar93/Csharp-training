using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.Title = "Hello World";
			//Console.BackgroundColor = ConsoleColor.Red;
			//Console.ForegroundColor = ConsoleColor.Black;
			//Console.Beep(500, 5000);
            //Console.WriteLine("Hello World");

			int a = 10; //this is a var

			//ask user for name
			Console.WriteLine("What is your name?");

			// save response in a var called name
			string name = Console.ReadLine();

			// display the name
			Console.WriteLine("Hello " + name + ", that's the BEST name");

			Console.WriteLine("What is your age?");

			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Hello {0}, your age is {1} yr(s) old", name, age);

			Console.ReadKey(); // allows console to remain open
		}
	}
}
