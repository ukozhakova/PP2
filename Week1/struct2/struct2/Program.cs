using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2
{
	class Patient
	{
		public string name;
		public double age;
		public int IIN;
		public Patient(string nm, double ae, int II)
		{
			this.age = ae;
			this.name = nm;
			this.IIN = II;
		}
		public void ReadInfo()
		{
			name = Console.ReadLine();
			IIN = Convert.ToInt32(Console.ReadLine());
			age = Convert.ToDouble(Console.ReadLine());
		}
		public void PrintInfo()
		{
			Console.WriteLine(name + " " + age + " " + IIN);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Patient> Pt = new List<Patient>();
			Random R = new Random();
			Random R2 = new Random();
			int n = 5;
			for (int i = 0; i < n; ++i)
			{
			double age = R.Next(15, 22) + R.NextDouble();
			int IIN = R2.Next(11111111, 99999999);
			Patient P = new Patient("A" + i, age, IIN);
			Pt.Add(P);
			}

			for (int i = 0; i < n - 1; ++i)
			{
				for (int j = i + 1; j < n; ++j)
				{
					if (Pt[i].age > Pt[j].age)
					{
						Patient t = Pt[i];
						Pt[i] = Pt[j];
						Pt[j] = t;
					}
				}
			}

			for (int i = 0; i < n; ++i)
			{
				Pt[i].PrintInfo();
			}
		}
	}
}


