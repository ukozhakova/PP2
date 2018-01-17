using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
	class Triangle
	{
		public double edge1;
		public double edge2;
		public double edge3;
		public double perimeter;
		public double area;
		public Triangle(double edge1, double edge2, double edge3)
		{
			this.edge1 = edge1;
			this.edge2 = edge2;
			this.edge3 = edge3;
			FindPerimeter();
			FindArea();
		}
		public void FindPerimeter()
		{
			perimeter = edge1 + edge2 + edge3;
		}
		public void FindArea()
		{
			area = Math.Sqrt(perimeter/2 * (perimeter/2 - edge1) * (perimeter/2 - edge2) * (perimeter/2 - edge3));
		}
		public override string ToString()
		{
			return "for edges equal to " + edge3 + " " + edge2 + " " + edge1 + " the perimeter and area of triangle are " + perimeter + " and  " + area;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			double edge1 = double.Parse(Console.ReadLine());
			double edge2 = double.Parse(Console.ReadLine());
			double edge3 = double.Parse(Console.ReadLine());
			Triangle Tr = new Triangle(edge1, edge2, edge3);
			Console.WriteLine(Tr);
		}
	}
}
