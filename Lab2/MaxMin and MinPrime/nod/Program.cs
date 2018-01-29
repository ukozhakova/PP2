using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nod
{
	class Program
	{
		public static int nod(int x, int y)
		{
			if (y == 0) return x;
			else return nod(Math.Min(y,x), Math.Max(x,y) % Math.Min(x,y));
		}
		static void Main(string[] args)
		{
			int x = 45;
			int y = 72;

			Console.WriteLine(nod(x, y));
		}
	}
} 