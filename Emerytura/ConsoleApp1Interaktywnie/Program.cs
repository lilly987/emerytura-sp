using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Interaktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            // tu piszemy kod
            Console.WriteLine("Program EMERYTURA");
            Console.Write("podaj swoje imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj, "+ imie + " " + nazwisko + "!");
            Console.WriteLine("witaj, {0} {1}!", nazwisko, imie);
            Console.WriteLine($"WITAJ {imie} {nazwisko}!");

            Console.Write("Podaj swój wiek: ");
            int wiek;
            string s = Console.ReadLine();
            wiek = int.Parse(s);

            Console.WriteLine($"Masz {wiek} lat.");
        }
    }
}
