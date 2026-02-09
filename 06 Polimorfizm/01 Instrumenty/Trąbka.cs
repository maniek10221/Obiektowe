using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Instrumenty
{
    internal class Trąbka: Instrument
    {
        public Trąbka()
        {
            this.waga = 5;
        }

        public new void Graj()
        {
            Console.WriteLine("Trąbka gra");
        }

        public override void Stroj()
        {
            Console.WriteLine("Trąbka strojona");
        }

        public void Dmuchaj()
        {
            Console.WriteLine("Trąbka dmuchana");
        }
    }
}
