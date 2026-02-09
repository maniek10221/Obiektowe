using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_abstrakcyjna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Pies();
            zwierze.WydajDzwiek();

            Szczeniak szczeniak = new Szczeniak();
            szczeniak.WydajDzwiek();
        }
    }

    abstract class Zwierze
    {
        public abstract void WydajDzwiek();
    }

    class Pies : Zwierze
    {
        public sealed override void WydajDzwiek()
        {
            Console.WriteLine("Pies szczeka");
        }

    }

    class Szczeniak : Pies
    {
        //public override void WydajDzwiek()
        //{
        //    Console.WriteLine("Szczeniak szczeka");
        //}
    }
}
