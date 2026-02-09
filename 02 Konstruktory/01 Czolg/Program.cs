using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Czolg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czolg c1 = new Czolg();
            Czolg c2 = new Czolg(101);
            Czolg c3 = new Czolg(102, "T34");
            Czolg c4 = new Czolg(103, "Tiger", new Dzialo(88));

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
