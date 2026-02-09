using System;

class Osoba
{
    private string _imie;
    private string _nazwisko;
    public DateTime? DataUrodzenia { get; set; }
    public DateTime? DataŚmierci { get; set; }

    public Osoba(string imięNazwisko)
    {
        ImięNazwisko = imięNazwisko;
    }

    public string Imię
    {
        get => _imie;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Imię nie może być puste.");
            }
            _imie = value;
        }
    }

    public string Nazwisko
    {
        get => _nazwisko;
        set => _nazwisko = value;
    }

    public string ImięNazwisko
    {
        get => $"{_imie} {_nazwisko}".Trim();
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _imie = "";
                _nazwisko = "";
            }
            else
            {
                string[] parts = value.Split(' ');
                _imie = parts[0];
                _nazwisko = parts.Length > 1 ? parts[parts.Length - 1] : "";
            }
        }
    }

    public TimeSpan? Wiek
    {
        get
        {
            if (DataUrodzenia.HasValue)
            {
                DateTime endDate = DataŚmierci ?? DateTime.Now;
                return endDate - DataUrodzenia.Value;
            }
            return null;
        }
    }
}