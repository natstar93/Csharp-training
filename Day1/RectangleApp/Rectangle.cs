using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
	class Rectangle
	{
		private int length, width;

		public Rectangle(int length, int width)
		{
			this.length = length;
			this.width = width;
		}

		public int CalculateArea()
		{
			return length * width;
		}

		public int CalculatePerimeter()
		{
			return 2 * (length + width);
		}
	}
}
