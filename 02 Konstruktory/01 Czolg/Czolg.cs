using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Czolg
{
    internal class Czolg
    {
        private int NumerCzolgu;
        private string NazwaCzolgu;
        private Dzialo dzialo;

        public Czolg(int numerCzolgu, string nazwaCzolgu, Dzialo dzialo)
        {
            NumerCzolgu = numerCzolgu;
            NazwaCzolgu = nazwaCzolgu;
            this.dzialo = dzialo;
        }

        public Czolg(int numerCzolgu, string nazwaCzolgu)
            : this(numerCzolgu, nazwaCzolgu, new Dzialo(78)) {}

        public Czolg(int numerCzolgu)
            : this(numerCzolgu, "Rudy") { }

        public Czolg()
            : this(102) { }

        public override string ToString() => $"Numer: {NumerCzolgu}, Nazwa: {NazwaCzolgu}, Kaliber działa: {dzialo.GetKaliber()}";
        
    }
}
