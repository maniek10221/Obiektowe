using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Osoba
{
    partial class Osoba
    {
        public string Imie;
        public string Nazwisko;
        private int RokUrodzenia;

        private bool CzyKobieta() => Imie.EndsWith("a");

        // tytuł imie, nazwisko urodzony w roku - getter
        public string PobierzInformacje() => $"{(CzyKobieta() ? "Pani" : "Pan")} {Imie} {Nazwisko} urodzony w roku {RokUrodzenia}";

        //setter rok urodzenia
        public void UstawRokUrodzenia(int rok)
        {
            if (DateTime.Now.Year - rok < 18) throw new ArgumentException("Osoba musi być pełnoletnia");
            this.RokUrodzenia = rok;
        }


        #region Zapis danych realizowany przez Mietka
        private int iloscZapisow = 0;

        public int IloscZapisow => iloscZapisow;

        partial void zapisz(int licznik);

        public void Zapisz() => zapisz(++iloscZapisow);
        

        #endregion
    }
}
