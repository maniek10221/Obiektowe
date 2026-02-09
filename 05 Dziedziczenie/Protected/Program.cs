using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Bazowa
    {
        private int a;
        internal int b; //zamienić na protected
        public int c;
    }

    class Pochodna : Bazowa
    {
        public void Metoda(Pochodna pochodna)
        {
            //int a = pochodna.a; // błąd
            int b = pochodna.b; // OK
            int c = pochodna.c; // OK
        }

        public void Metoda2(Bazowa bazowa)
        {
            //int a = bazowa.a; // błąd
            int b = bazowa.b; // błąd
            int c = bazowa.c; // OK
        }
    }
}
