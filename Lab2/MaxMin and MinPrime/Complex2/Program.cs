using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleComplexNumbers
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
		public void Simple()
		{
			int a_ = a;
			int b_ = b;
			int c = nod(a_, b_);
			this.a = this.a / c;
			this.b = this.b / c;
		}
		public static Complex operator +(Complex m, Complex n)
		{
			Complex p = new Complex((m.a * n.b + m.b * n.a) / nod(m.b, n.b), (m.b * n.b) / nod(m.b, n.b)); // 5/9 + 1/3 15+9/9
			p.Simple();
			return p;
		}
		
		public static int nod(int x, int y)
		{
			if (y == 0) return x;
			else return nod(y, y % x);
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
			string a = Console.ReadLine();
			string[] a1 = new string[2];
			a1 = a.Split('/');
			string b = Console.ReadLine();
			string[] b1 = new string[2];
			b1 = b.Split('/');
			int l = int.Parse(a1[0]);
			int m = int.Parse(a1[1]);
			int a2 = int.Parse(b1[0]);
			int o = int.Parse(b1[1]);
			Complex q = new Complex(l, m);
			Complex w = new Complex(a2, o);
			Complex e = q + w;
			Console.WriteLine(e.ToString());
			Console.ReadKey();
		}
	}
}