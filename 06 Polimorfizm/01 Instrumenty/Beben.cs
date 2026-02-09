using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Instrumenty
{
    internal class Beben: Instrument
    {
        public Beben()
        {
            this.waga = 10;
        }

        public new void Graj()
        {
            Console.WriteLine("Bęben gra");
        }

        public override void Stroj()
        {
            Console.WriteLine("Bęben strojony");
        }

        public void Uderz()
        {
            Console.WriteLine("Bęben uderzony");
        }
    }
}
