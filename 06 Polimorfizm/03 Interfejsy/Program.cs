using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IInterfejs
    {
        int Metoda(int n);
    }

    interface IInterfejs2 
    {
        int Metoda2(int n);
    }

    class Klasa : IInterfejs
    {
        public int Metoda(int n)
        {
            return 2*n;
        }
    }

    class Klasa2 : IInterfejs, IInterfejs2
    {
        public int Metoda(int n)
        {
            return 3 * n;
        }

        public int Metoda2(int n)
        {
            return 4 * n;
        }

        public int Metoda3(int n)
        {
            return 5 * n;
        }
    }
}
