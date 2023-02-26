using P01AplikacjaZawodnicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] napisy = { "BACHLEDA", "MATEJA", "HERR" };

            string[] w1= napisy.Where(mojaZmienna => mojaZmienna.Length>4).ToArray();

            int[] liczby = { 4, 6, 7, 3, 2, 7, 4 };

            int[] w2= liczby
                .Where(x => x > 5)
                .OrderBy(x=>x)
                .ToArray();

            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            ManagerZawodnikow mz = new ManagerZawodnikow(SposobPolaczenia.Plik, url);
            mz.WczytajZawodnikow();
            Zawodnik[] zawodnicy = mz.TablicaZawodnikow;

            // wyszukaj zawodnikow, ktróych nazwisko kończy się na litere "a"
            // oraz wzrost jest ponad 2 razy wiekszy niż waga 
            // uruodznych w II polowie roku 
            // i posorotuj po dlugosci imienia 

            Zawodnik[] w4 = zawodnicy.Where(x => x.Nazwisko.EndsWith("a") &&
                               x.Wzrost > 2 * x.Waga &&
                               x.DataUrodzenia.Month > 6)
                     .OrderBy(x => x.Imie.Length)
                     .ThenByDescending(x=>x.Wzrost)
                   //  .Select(x=>x)
                     .ToArray();


            string[] w5 = zawodnicy.Select(x => x.Nazwisko).ToArray();


            string[] w6 =  zawodnicy.Select(x => x.Imie + " " + x.Nazwisko).ToArray();

            ZawodnikMini[] w7 =
                zawodnicy.Select(x => new ZawodnikMini() { Imie = x.Imie, Nazwisko = x.Nazwisko }).ToArray();

            var w8 =
                zawodnicy.Select(x => new ZawodnikMini()
                {
                    Imie = x.Imie,
                    Nazwisko = x.Nazwisko,
                    BMI = x.Waga / Math.Pow(x.Wzrost / 100.0, 2)
                }).ToArray();


            var w9 = 
                zawodnicy.Select(x => new
                {
                    MojeImie = x.Imie,
                    MojeNazwisko = x.Nazwisko,
                    BMI = x.Waga / Math.Pow(x.Wzrost / 100.0, 2),
                    Wspolczynnik = x.Waga/x.Wzrost
                }).ToArray();

            string nazwisko = w9[0].MojeNazwisko;
            foreach (var item in w9)
                Console.WriteLine(  item.MojeImie + " " + item.MojeNazwisko);

            // wpisz nazwiska zawodników wraz z długością tego nazwiska 

            //var w10 = zawodnicy.Select(x => new { Nazwisko = x.Nazwisko, Dlugosc = x.Nazwisko.Length }).ToArray();
            var w10 = zawodnicy.Select(x => new { x.Nazwisko, Dlugosc = x.Nazwisko.Length }).ToArray();

            //foreach (var item in w1)
            //    Console.WriteLine(  item);

            Console.ReadKey();
        }
    }
}
