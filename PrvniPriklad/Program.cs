using System;

namespace PrvniPriklad
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public Clovek()
        {
            Jmeno = "Neznáme";
            Prijmeni = "Neznáme";
        }

        public Clovek(string j, string p)
        {
            Jmeno = j;
            Jmeno = p;
        }

    class Obcan : Clovek
    {
        int RodneCislo = 
    }
}
