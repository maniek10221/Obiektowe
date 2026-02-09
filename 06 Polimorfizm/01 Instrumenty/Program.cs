using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Instrumenty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instrument instrument = new Instrument();
            //((Beben)instrument).Graj();
            Console.WriteLine("A - trąbka");
            Console.WriteLine("B - bęben");
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case 'a':
                case 'A':
                    instrument = new Trąbka();
                    break;
                case 'b':
                case 'B':
                    instrument = new Beben();
                    break;
            }

            instrument.Graj(); // Instrument gra
            instrument.Stroj(); // zależy od wyboru użytkownika
            if (instrument is Trąbka)
            {
                ((Trąbka)instrument).Dmuchaj();
            }
            else if (instrument is Beben)
            {
                ((Beben)instrument).Uderz();
            }

            Console.WriteLine($"typ: {instrument.GetType()}");

        }
    }
}
