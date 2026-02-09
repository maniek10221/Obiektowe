using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzymy nowego pieska
            Pies piesek = new Pies();
            piesek.Imie = "Burek";
            piesek.Wiek = 5;
            piesek.Rasa = "Owczarek Niemiecki";
            piesek.PrzedstawSie();
            piesek.Szczekaj();
        }
    }

    public class Zwierze
    {
        public string Imie { get; set; }
        public int Wiek { get; set; }

        public Zwierze(string imie, int wiek)
        {
            Imie = imie;
            Wiek = wiek;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine("Jestem zwierzęciem o imieniu {0} i mam {1} lat", Imie, Wiek);
        }
    }

    // Klasa Pies dziedziczy po klasie Zwierze
    public class Pies : Zwierze
    {

        //konstruktor klasy Pies
        public Pies()
            : base("Bezimienny", 0)
        {
        }

       //właściwość Rasa
       public string Rasa { get; set; }

       //metoda Szczekaj
       public void Szczekaj()
       {
           Console.WriteLine("Hau Hau");
       }

       //przesłonięcie metody PrzedstawSie
       public new void PrzedstawSie()
       {
              Console.WriteLine("Jestem psem o imieniu {0}, mam {1} lat i jestem rasy {2}", Imie, Wiek, Rasa);
         }

       
    }
}
