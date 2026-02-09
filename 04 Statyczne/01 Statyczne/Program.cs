using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Statyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Pierwsza.a = {Pierwsza.a}"); //Pierwsza.a = 1

            //tworzenie obiektu klasy Pierwsza
            Pierwsza p1 = new Pierwsza(2, 3);

            Console.WriteLine(p1); //a = 3, b = 5 bo a = 1 + 2, b = 2 + 3 - pokazuje wartosci 4 i 5 bo wywołany jest konstruktor statyczny

            Console.WriteLine($"Pierwsza.a = {Pierwsza.a}");

            //przypsuję do zmiennej statycznej wartość 10
            Pierwsza.a = 10;
            Console.WriteLine($"Pierwsza.a = {Pierwsza.a}"); //Pierwsza.a = 10
        }
    }

    class Pierwsza
    {
        //pole statyczne a
        public static int a = 1;
        //zwykłe pole b
        public int b = 2;

        //konstruktor
        public Pierwsza(int x, int y)
        {
            a += x;
            b += y;
        }

        //statyczny konstruktor, dodaje 1 do a i 1 do b
        static Pierwsza()
        {
            a++;
            //b++; //b jest polem niestatycznym, nie można odwołać się do niego w statycznym konstruktorze
        }

        //nadpisanie metody ToString
        public override string ToString()
        {
            return $"a = {a}, b = {b}";
        }


    }
}
