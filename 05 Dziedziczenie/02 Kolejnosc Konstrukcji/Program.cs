using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Kolejnosc_Konstrukcji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new CK();
            new CK(1);
        }
    }

    class AK
    {
        public AK()
        {
            Console.WriteLine("Konstruktor klasy AK");
        }

        public AK(int i)
        {
            Console.WriteLine($"Konstruktor klasy AK z parametrem {i}");
        }
    }

    class BK : AK
    {
        public BK() : base()
        {
            Console.WriteLine("Konstruktor klasy BK");
        }

        public BK(int i) : base(i)
        {
            Console.WriteLine($"Konstruktor klasy BK z parametrem {i}");
        }
    }

    class CK : BK
    {
        public CK() : base()
        {
            Console.WriteLine("Konstruktor klasy CK");
        }

        public CK(int i) : base(i)
        {
            Console.WriteLine($"Konstruktor klasy CK z parametrem {i}");
        }
    }
}
