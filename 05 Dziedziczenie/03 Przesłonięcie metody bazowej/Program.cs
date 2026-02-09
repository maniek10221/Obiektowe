using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Przesłonięcie_metody_bazowej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bazowa b = new Bazowa();
            b.Metoda(); // Metoda klasy bazowej
            b.MetodaWirtualna(); // Metoda wirtualna klasy bazowej

            Pochodna p = new Pochodna();
            p.Metoda(); // Metoda klasy pochodnej
            p.MetodaWirtualna(); // Metoda wirtualna klasy bazowej

            Bazowa bp = new Pochodna();
            bp.Metoda();
        }
    }

    class Bazowa
    {
        public void Metoda()
        {
            Console.WriteLine("Metoda klasy bazowej");
        }

        //metoda wirtualna
        public virtual void MetodaWirtualna()
        {
            Console.WriteLine("Metoda wirtualna klasy bazowej");
        }
    }

    class Pochodna : Bazowa
    {
        public new void Metoda()
        {
            Console.WriteLine("Metoda klasy pochodnej");
        }

        public override void MetodaWirtualna()
        {
            Console.WriteLine("Metoda wirtualna klasy pochodnej");
        }
    }
}
