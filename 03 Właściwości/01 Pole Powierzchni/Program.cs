using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Pole_Powierzchni
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // utworzenie obiektu klasy PolePowierzchni
            PolePowierzchni polePowierzchni = new PolePowierzchni(1000);
            Console.WriteLine($"Pole powierzchni wynosi {polePowierzchni.MetrKwadratowy}, " +
                $"Arów {polePowierzchni.Ar}, Hektarów { polePowierzchni.Hektar}");


            Console.ReadKey();
            
        }
    }

    class PolePowierzchni
    {
        //konstruktor
        public PolePowierzchni(double metrKwadratowy) => MetrKwadratowy = metrKwadratowy;
        
        // właściwość przechowująca ilość metrów kwadratowych
        public double MetrKwadratowy { get; set; }

        //właściwość obliczająca pole powierzchni w arach
        //public double Ar
        //{
        //    set { MetrKwadratowy = 100 * value;} //Ar to 100 m2
        //    get { return MetrKwadratowy / 100; }
        //}

        //właściwość obliczająca pole powierzchni w arach
        public double Ar
        {
            set => MetrKwadratowy = 100 * value; 
            get => MetrKwadratowy / 100;
        }

        //właściwość obliczająca pole powierzchni w hektarach
        public double Hektar
        {
            set => MetrKwadratowy = 10000 * value; //1 ha to 10000 m2
            get => MetrKwadratowy / 10000;
        }

    }
}
