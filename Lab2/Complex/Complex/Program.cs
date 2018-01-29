using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
	class Complex
	{
		public int a;
		public int b;
		public Complex(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		
		public static Complex operator +(Complex m, Complex n)
		{
			int s= (m.a * n.b + m.b * n.a); //1*24 + 3*7=45
			int d = (m.b * n.b); // 3*24
			int u = Nod(s, d); //nod(45,72)=9
			Complex p = new Complex(s /u, d /u); 
			return p; 
		}

		public static int Nod(int x, int y)
		{
			if (y == 0) return x;
			else return Nod(Math.Min(y, x), Math.Max(x, y) % Math.Min(x, y));
		}
		public override string ToString()
		{
			return a + "/" + b;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Complex c1 = new Complex(1, 3);
			Complex c2 = new Complex(7, 24);
			Complex result = c1+c2;
			Console.WriteLine(result);
		}
	}
}