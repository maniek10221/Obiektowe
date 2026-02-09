using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Osoba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba m = new Osoba();
            Osoba k = new Osoba();

            m.Imie = "Jan";
            m.Nazwisko = "Kowalski";

            k.Imie = "Anna";
            k.Nazwisko = "Nowak";

            m.UstawRokUrodzenia(1990);
            k.UstawRokUrodzenia(2005);

            Console.WriteLine($"k - {k.PobierzInformacje()}");
            Console.WriteLine($"m - {m.PobierzInformacje()}");

            m.Zapisz();
            k.Zapisz();
            m.Zapisz();
            k.Zapisz();

            Console.WriteLine($"m: ilosć zapisów do pliku {m.IloscZapisow}" );
            Console.WriteLine($"k: ilosć zapisów do pliku {k.IloscZapisow}");
            
        }
    }
}
