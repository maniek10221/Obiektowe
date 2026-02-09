using System;
using System.Collections.Generic;

public class Prostokąt
{
    private double bokA;
    private double bokB;

    // Konstruktory
    public Prostokąt(double bokA, double bokB)
    {
        BokA = bokA;
        BokB = bokB;
    }

    // Pola niepubliczne
    private double BokA
    {
        get => bokA;
        set
        {
            if (!double.IsFinite(value) || value < 0)
            {
                throw new ArgumentException("Wartość BokA musi być skończoną nieujemną liczbą.");
            }
            bokA = value;
        }
    }

    private double BokB
    {
        get => bokB;
        set
        {
            if (!double.IsFinite(value) || value < 0)
            {
                throw new ArgumentException("Wartość BokB musi być skończoną nieujemną liczbą.");
            }
            bokB = value;
        }
    }

    // Statyczny słownik
    private static readonly Dictionary<char, double> wysokośćArkusza0 = new Dictionary<char, double>
    {
        ['A'] = 1189,
        ['B'] = 1414,
        ['C'] = 1297
    };

    // Publiczna statyczna metoda
    public static Prostokąt ArkuszPapieru(string format)
    {
        if (string.IsNullOrWhiteSpace(format) || format.Length < 2)
        {
            throw new ArgumentException("Niepoprawny format.");
        }

        char X = format[0];
        if (!wysokośćArkusza0.ContainsKey(X))
        {
            throw new ArgumentException("Niepoprawny szereg.");
        }

        if (!byte.TryParse(format.Substring(1), out byte i))
        {
            throw new ArgumentException("Niepoprawny indeks.");
        }

        double wysokość = wysokośćArkusza0[X];
        double pierwiastekZDwóch = Math.Sqrt(2);
        double bokA = wysokość / Math.Pow(pierwiastekZDwóch, i);
        double bokB = bokA / pierwiastekZDwóch;

        return new Prostokąt(bokA, bokB);
    }

    public override string ToString()
    {
        return $"Prostokąt: BokA = {bokA}, BokB = {bokB}";
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Prostokąt arkuszA0 = Prostokąt.ArkuszPapieru("A0");
            Console.WriteLine(arkuszA0);

            Prostokąt arkuszA1 = Prostokąt.ArkuszPapieru("A1");
            Console.WriteLine(arkuszA1);

            Prostokąt arkuszB2 = Prostokąt.ArkuszPapieru("B2");
            Console.WriteLine(arkuszB2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}
