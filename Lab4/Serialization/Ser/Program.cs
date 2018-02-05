using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml
{
    [Serializable]
    public class Complex 
    {
        public int x;
        public int y;
        public Complex() { }
        public Complex(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public int Gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else if (b > a)
                {
                    b -= a;
                }

            }
            return a;
        }
        public int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }
        public int Simplify(int a, int b)
        {
            List<int> g = new List<int:angry:);
            int cnt = 0;
            for (int i = 1; i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    g.Add(i);
                    cnt++;
                }
            }
            int[] k = new int[cnt];
            int maxx = k[0];
            for (int i = 0; i < cnt; i++)
            {
                k[i] = g[i];
            }
            for (int i = 0; i < cnt; i++)
            {
                if (k[i] > maxx)
                {
                    maxx = k[i];
                }
                else
                {
                    continue;
                }
            }
            int s = maxx;

            return s;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex n = new Complex();

            n.y = n.Lcm(c1.y, c2.y);
            c1.x = (n.y / c1.y) * c1.x;
            c2.x = (n.y / c2.y) * c2.x;
            n.x = c1.x + c2.x;
            int v = n.Simplify(n.x, n.y);
            n.y = n.y / v;
            n.x = n.x / v;
            return n;

        }
        public override string ToString()
        {
            return x + " " + y;
        }

    }
    class Program
    {
        static void f1(Complex a)
        {
            FileStream fs = new FileStream(@"maks.xml", FileMode.Create, FileAccess.Write);
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
        static void f2()
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
            Complex c1 = new Complex(1, 3);
            Complex c2 = new Complex(1, 2);
            Complex result = c1 + c2;
            f1(result);
            f2();
            Console.ReadKey();
        }
    }
}