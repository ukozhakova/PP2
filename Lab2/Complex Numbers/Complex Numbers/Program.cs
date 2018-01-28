using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Numbers
{
	class Complex
	{
		public int x, y; //my variables will be in the form x+yi

		public Complex(int x, int y) //constructor
		{
			this.x = x; //присваиваю значения
			this.y = y;
		}

		public static Complex operator +(Complex c1, Complex c2)
		{
			int a = c1.x + c2.x; //new variable, responding for part of number without i
			int b = c1.y + c2.y; //new variable, responding for part of number with i
			Complex n = new Complex(a, b); //new complex number
			return n;
		}
		public static Complex operator *(Complex c1, Complex c2)
		{
			int a = (c1.x* c2.x) - (c1.y*c2.y);  //new variable, responding for part of number without i
			int b = (c1.x * c2.y) + (c2.x*c1.y); //new variable, responding for part of number with i
			Complex m = new Complex(a, b);
			return m;
		}

		public override string ToString() //переписываю метод
		{
			return x + " + " + y + "i"; //my answer will return in this form
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Complex c1 = new Complex(3, 5);
			Complex c2 = new Complex(2, 4);
			Complex sum = c1 + c2;
			Complex product = c1 * c2;
			Console.WriteLine("sum of 2 numbers is " + sum);
			Console.WriteLine("product of 2 numbers is " + product);
		}
	}
}
/* 3+5i + 2+4i = 5 + 9i
 * (3 + 5i)*(2 + 4i) = 6-20 + 22i
 * */
