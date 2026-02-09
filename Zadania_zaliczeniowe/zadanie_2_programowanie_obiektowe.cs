using System;
using System.Collections.Generic;
using System.Drawing;

class Prostokąt
{
    private double _bokA;
    private double _bokB;

    public double BokA
    {
        get => _bokA;
        private set
        {
            if (value <= 0 || double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentException("Długość boku musi być skończoną nieujemną liczbą.");
            _bokA = value;
        }
    }

    public double BokB
    {
        get => _bokB;
        private set
        {
            if (value <= 0 || double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentException("Długość boku musi być skończoną nieujemną liczbą.");
            _bokB = value;
        }
    }

    private static readonly Dictionary<char, decimal> wysokośćArkusza0 = new Dictionary<char, decimal>
    {
        ['A'] = 1189,
        ['B'] = 1414,
        ['C'] = 1297
    };

    public Prostokąt(double bokA, double bokB)
    {
        BokA = bokA;
        BokB = bokB;
    }

    public static Prostokąt ArkuszPapieru(string format)
    {
        if (string.IsNullOrEmpty(format) || format.Length < 2)
            throw new ArgumentException("Niepoprawny format arkusza papieru.");

        char seria = format[0];
        int indeks;

        if (!int.TryParse(format.Substring(1), out indeks))
            throw new ArgumentException("Niepoprawny format arkusza papieru - indeks.");

        if (!wysokośćArkusza0.ContainsKey(seria))
            throw new ArgumentException("Nieznana seria arkusza papieru.");

        double pierwiastekZDwóch = Math.Sqrt(2);
        decimal bazowaWysokość = wysokośćArkusza0[seria];
        double wysokość = (double)bazowaWysokość;
        double bokA = wysokość / Math.Pow(pierwiastekZDwóch, indeks);
        double bokB = bokA / pierwiastekZDwóch;

        return new Prostokąt(bokA, bokB);
    }
}

class Program
{
    static void Main()
    {
        Prostokąt arkuszA0 = Prostokąt.ArkuszPapieru("A0");
        Console.WriteLine($"Wymiary arkusza A0: {arkuszA0.BokA} mm x {arkuszA0.BokB} mm");

        // Rysowanie prostokąta za pomocą System.Drawing
        using (Bitmap bmp = new Bitmap(300, 200))
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen, 50, 50, (float)arkuszA0.BokA, (float)arkuszA0.BokB);
            }
            bmp.Save("prostokat.png");
        }
    }
}
