using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(1, 1);
            Punkt p2 = new Punkt(2, 2);
            Console.WriteLine($"Odległość między punktami {p1} i {p2} wynosi {p1.Dist(p2)}");
        }
    }
}
