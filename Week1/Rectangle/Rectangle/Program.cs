using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
	class Rectangle
	{
		public double length;
		public double width;
		public double area;
		public Rectangle(double length, double width)
		{
			this.length = length;
			this.width = width;
			findArea();
		}
		public void findArea()
		{
			area=length*width;
		}
		public override string ToString()
		{
			return "for the rectangle with length of " + length + " and width of " + width + " area is " + area;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
				double length = double.Parse(Console.ReadLine());
				double width = double.Parse(Console.ReadLine());
				Rectangle R = new Rectangle(length,width);
				Console.WriteLine(R);
		}
	}
}
