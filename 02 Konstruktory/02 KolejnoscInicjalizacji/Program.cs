using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KolejnoscInicjalizacji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pierwsza p1 = new Pierwsza(); //2
            Pierwsza p2 = new Pierwsza(3); //3
            Console.WriteLine($"p1 {p1.x}");
            Console.WriteLine($"p2 {p2.x}");
            Pierwsza p3 = new Pierwsza { x = 4 }; //4
            Console.WriteLine($"p3 {p3.x}");

            Pierwsza p4 = new Pierwsza(5) { x = 6 }; //6
            Console.WriteLine($"p4 {p4.x}");
        }
    }

    class Pierwsza
    {
        public int x = 1;

        public Pierwsza(int x) => this.x = x;
        
        public Pierwsza() : this(2) { }
        
    }

}
