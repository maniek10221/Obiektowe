using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rozszerzenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rozszerzenie rozszerzenie = new Rozszerzenie();
            //Console.WriteLine(rozszerzenie.Potega(2, 3));

            //int x = 2;
            Console.WriteLine(2.Potega(3));

            Console.ReadKey();
        }
    }

    static class Rozszerzenie
    {
        public static double Potega(this int podstawa, int wykladnik)
        {
            double wynik = 1;
            for (int i = 0; i < wykladnik; i++)
            {
                wynik *= podstawa;
            }
            return wynik;
        }
       
    }
}
