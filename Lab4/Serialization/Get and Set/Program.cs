using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_Set
{
    class Student
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1)
                    year = 1;
                else if (value > 5)
                    year = 5;
                else year = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Year = 5;
            Console.WriteLine(S1.Year);
        }
    }
}
