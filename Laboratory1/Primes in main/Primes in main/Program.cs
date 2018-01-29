using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_main 
{
	class Program
	{
		/// <summary>
		/// Function for checking is it prime
		/// </summary>
		/// <param name="x">possible prime number</param>
		/// <returns></returns> 
		static bool IsPrime(int x)
		{
			bool res = true;

			if (x == 1) return false; //special case

			for (int i = 2; i <= Math.Sqrt(x); ++i)
			{
				if (x % i == 0)
				{
					res = false; 
					break; //если х делится на какое-то число, то дальше нет смысла проверять
				}
			}

			return res; //вернет true or false
		}

		static void Main(string[] args)
		{
			foreach (string s in args)
			{
				if (IsPrime(int.Parse(s))) //проверяет на простоту
				{
					Console.WriteLine(s); //выводит простое число, иначе ниче не делает
				}
			}
		}
	}
}
