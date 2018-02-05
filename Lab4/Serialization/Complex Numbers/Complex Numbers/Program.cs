using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML 
{
    [Serializable]
	public class Complex
	{
        public int x;
        [NonSerialized] 
        public int y; //my variables will be in the form x+yi

		public Complex(int x, int y) //constructor
		{
			this.x = x; //присваиваю значения
			this.y = y;
		}
        public Complex ()
        {

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
        static void F1(Complex a)
        {
            FileStream fs = new FileStream(@"maks1.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            try
            {
                xs.Serialize(fs, a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            Console.WriteLine("Done");
        }
        static void F2()
        {
            FileStream fs = new FileStream(@"maks.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            try
            {
                Complex a = xs.Deserialize(fs) as Complex;
                Console.WriteLine(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                fs.Close();
            }
        }
        static void Main(string[] args)
		{
			Complex c1 = new Complex(3, 5);
			Complex c2 = new Complex(2, 4);
			Complex sum = c1 + c2;
            Complex product = c1 * c2;
            F1(sum);
            F1(product);
            F2();
            
		}
	}
}
