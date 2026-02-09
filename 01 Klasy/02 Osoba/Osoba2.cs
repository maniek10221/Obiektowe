using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Osoba
{
    partial class Osoba
    {
        partial void zapisz(int licznik)
        {
            StreamWriter sw = null;
            string nazwa = string.Format($"{Imie}{Nazwisko}{iloscZapisow}.txt");
            try
            {
                sw = new StreamWriter(nazwa);
                sw.WriteLine($"Imie: {Imie}");
                sw.WriteLine($"Nazwisko: {Nazwisko}");
                sw.WriteLine($"Rok urodzenia: {RokUrodzenia}");
                sw.WriteLine($"Data zapisu: {DateTime.Now}");
                sw.WriteLine($"Numer zapisu:{iloscZapisow}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}
