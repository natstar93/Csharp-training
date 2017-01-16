using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
	class Operators
	{
		//instance variables
		int a = 10;
		int b = 20;

		/// <summary>
		/// This is the Arithmetic operator
		/// </summary>
		public void Arithmetic()
		{
			Console.WriteLine("Arithmetic operators below...");
			Console.WriteLine("a is {0} and b is {1}", a, b);
			Console.WriteLine("(a+b) is {0}", (a + b));
			Console.WriteLine("(a-b) is {0}", (a - b));
			Console.WriteLine("(a*b) is {0}", (a * b));
			Console.WriteLine("(a/b) is {0}", (a / Convert.ToDouble(b)));
			Console.WriteLine("(a Modulus b) is {0}", (a % b));

			Console.WriteLine("a is {0} and b is {1}", a, b);
			Console.WriteLine("a++ is {0}", a++);
			Console.WriteLine("++b is {0}", ++b);

			Console.WriteLine("a is {0} and b is {1}", a, b);
			Console.WriteLine("a-- is {0}", a--);
			Console.WriteLine("--b is {0}", --b);
		}

		public void Relational()
		{
			Console.WriteLine("Relational operators below...");

			Console.WriteLine("a is {0} and b is {1}", a, b);

			Console.WriteLine("(a>b) is {0}", (a > b));
			Console.WriteLine("(a<b) is {0}", (a < b));
			Console.WriteLine("(a>=b) is {0}", (a >= b));
			Console.WriteLine("(a<=b) is {0}", (a <= b));
			Console.WriteLine("(a == b) is {0}", (a == b));
			Console.WriteLine("(a != b) is {0}", (a != b));
		}

		public void Logical(bool a, bool b) // local variables
		{
			Console.WriteLine("a is {0} b is {1}", a, b);
			Console.WriteLine("a AND b is {0}", a && b);
			Console.WriteLine("a OR b is {0}", a || b);
			Console.WriteLine("a XOR b is {0}", a ^ b);
			Console.WriteLine("not a OR b is {0}", !(a || b));
		}

		public void Assignment(int a, int b)
		{
			Console.WriteLine("Assignment operators below...");

			int c = a + b; //assign a new value to c

			c += a; // c = c + a;
			Console.WriteLine("c += a is {0}", c);

			c -= a; // c = c - a;
			Console.WriteLine("c -= a is {0}", c);

			c *= a; // c = c * a;
			Console.WriteLine("c *= a is {0}", c);

			c /= a; // c = c / a;
			Console.WriteLine("c /= a is {0}", c);

			c %= a; // c = c % a;
			Console.WriteLine("c %= a is {0}", c);

		}
	}
}
