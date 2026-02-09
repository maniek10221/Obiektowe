using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Czolg
{
    internal class Dzialo
    {
        private double kaliber;

        public Dzialo(double kaliber)
        {
            this.kaliber = kaliber;
        }

        public double GetKaliber() => kaliber;
        public void SetKaliber(double kaliber) => this.kaliber = kaliber;
    }
}
