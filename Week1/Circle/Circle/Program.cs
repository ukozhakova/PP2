using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
	class Circle
	{
		public double radius;
		public double area;
		public double length;
		public Circle(double radius)
		{
			this.radius = radius;
			FindAreaandLength();
		}
		public void FindAreaandLength()
		{
			area = Math.PI * radius * radius;
			length = 2 * Math.PI * radius;

		}
		public override string ToString()
		{
			return "for radius equals to " + radius + " area is " + area+ " and length is " + length;
			 
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
				double r = double.Parse(Console.ReadLine());
				Circle C = new Circle(r);
				Console.WriteLine(C);
		}
	}
}
