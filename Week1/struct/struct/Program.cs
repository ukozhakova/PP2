using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulbo
{
	class Student
	{
		public string name;
		public string sname;
		public double gpa;

		public Student()
		{
			name = "Ulbossyn";
			sname = "Kozhakova";
			gpa = 3.47;
		}

		public Student(string n, string sn, double g)
		{
			name = n;
			sname  = sn;
			gpa = g;
		}
		public override string ToString()
		{
			return name + " " + sname + " " + gpa;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Student s = new Student();
			s.name = "Ulbossyn";
			Console.WriteLine(s);

			Student s2 = new Student("Daniel","Kang", 4);
			Console.WriteLine(s2);
		}
	}
}

