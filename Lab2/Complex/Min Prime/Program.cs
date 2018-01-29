using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2MinPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Vector = new List<int>();
            string text = File.ReadAllText(@"C:\Users\Мадина\Desktop\PP2\MinandMax.txt");
            string[] a = text.Split();
            int[] n = new int[a.Count()];
            for (int i = 0; i < a.Length; i++)
            {
                n[i] = int.Parse(a[i]);
                bool res = true;
                for (int j = 2; j * j <= n[i]; j++)
                {
                    if (n[i] % j == 0)
                    {
                        res = false;
                        break;
                    }
                }
                if (res & n[i] != 1)
                {
                    Vector.Add(n[i]);
                }
            }
            Vector.Sort();
            if (Vector.Count == 0)
            {
                File.WriteAllText(@"C:\Users\Мадина\Desktop\PP2\WriteHere.txt", "There are no primes");
            }
            for (int i = 0; i < Vector.Count; i++)
            {
                if (Vector.Count > 0)
                {
                    File.WriteAllText(@"C:\Users\Мадина\Desktop\PP2\WriteHere.txt", Convert.ToString(Vector[0]));
                }
                break;
            }
        }
    }
}