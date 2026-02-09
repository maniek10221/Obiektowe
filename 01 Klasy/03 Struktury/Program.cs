using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Struktury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Klasa k1 = new Klasa();
            k1.X = 10;
            Klasa k2 = k1;
            k2.X = 20;
            Console.WriteLine($"k1.X = {k1.X}, k2.X = {k2.X}");

            Struktura s1 = new Struktura();
            s1.X = 10;
            Struktura s2 = s1;
            s2.X = 20;
            Console.WriteLine($"s1.X = {s1.X}, s2.X = {s2.X}");
        }

        class Klasa
        {
            public int X = 0;
        }

        struct Struktura
        {
            public int X;
        }
    }
}
