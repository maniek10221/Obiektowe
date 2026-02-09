using System;

namespace _01_Punkt
{
    class Punkt
    {
        public double X = 0, Y = 0;

        public Punkt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Dist(Punkt p)
        {
            return Math.Sqrt(Math.Pow(p.X - this.X, 2) + Math.Pow(p.Y - this.Y, 2));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}