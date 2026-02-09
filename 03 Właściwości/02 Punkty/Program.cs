using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Punkty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt = new Punkt();
            punkt["x"] = 10;
            punkt["y"] = 20;
            Console.WriteLine($"x = {punkt["x"]}, y = {punkt["y"]}"); //10, 20
        }
    }

    class Punkt
    {
        private int x;
        private int y;

        //indeksator - podaję nazwę współrzędnej (x lub y) i zwraca mi wartość współrzędnej
        public int this[string nazwaWsp]
        {
            get
            {
                if(nazwaWsp == "x")
                    return x;
                else if (nazwaWsp == "y")
                    return y;
                else
                    throw new ArgumentException("Błędna nazwa współrzędnej");
            }
            set
            {
                if(nazwaWsp == "x")
                    x = value;
                else if (nazwaWsp == "y")
                    y = value;
                else
                    throw new ArgumentException("Błędna nazwa współrzędnej");
            }
        }
    }
}
