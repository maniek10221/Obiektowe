using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Instrumenty
{
    internal class Instrument
    {
        protected int waga = 0;

        public void Graj()
        {
            Console.WriteLine("Instrument gra");
        }

        public virtual void Stroj()
        {
            Console.WriteLine("Instrument strojony");
        }
    }
}
