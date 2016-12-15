using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        delegate double Funkcija(double x);

        static void IspišiFunkciju(Funkcija fja, double x1, double x2, int n)
        {
            Console.WriteLine("Ispis funkcije {0}:", fja.Method);
            Console.WriteLine("{0} {1}", "x", "y");
            for (int i = 0; i < n; ++i)
            {
                double x = x1 + (x2 - x1) / (n - 1) * i;
                Console.WriteLine("{0} {1}", x, fja(x));
            }
        }
        
        static void Main(string[] args)
        {
            // kvadrat broja
            Funkcija f = x => x * x;
            Console.WriteLine(f(5));

            // kub broja
            f = x => x * x * x;
            Console.WriteLine(f(5));

            // TODO: Ispisati tablicu kvadrata tako da se u pozivu metode IspišiFunkciju navede lambda izraz.

            IspišiFunkciju(x => x * x, 0, 10, 11);
            
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
