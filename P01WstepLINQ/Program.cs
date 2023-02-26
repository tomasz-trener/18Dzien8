using P01AplikacjaZawodnicy;
using System;
using System.Collections.Generic;
using System.Data;
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

            // inny alternatywny zapis 

            Zawodnik[] w4b = (from x in zawodnicy
                              where x.Wzrost > 2 * x.Waga && x.DataUrodzenia.Month > 6
                              orderby x.Imie.Length, x.Wzrost
                              select x
                              ).ToArray();
                             



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
            //foreach (var item in w9)
            //    Console.WriteLine(  item.MojeImie + " " + item.MojeNazwisko);

            // wpisz nazwiska zawodników wraz z długością tego nazwiska 

            //var w10 = zawodnicy.Select(x => new { Nazwisko = x.Nazwisko, Dlugosc = x.Nazwisko.Length }).ToArray();
            var w10 = zawodnicy.Select(x => new { x.Nazwisko, Dlugosc = x.Nazwisko.Length }).ToArray();


            var w11 =
            zawodnicy.GroupBy(x => x.Kraj).Select(x => new
            {
                Kraj = x.Key,
                SredniWzrost = Math.Round(x.Average(y => y.Wzrost),2)
            })
            .ToArray();
            
            foreach (var item in w11)
                Console.WriteLine(item.Kraj + " " + string.Format("{0:0.00}", item.SredniWzrost));

            double w12= zawodnicy.Average(x => x.Wzrost);

            // wypisz wszystkie wartości długości nazwiska, wraz z informacją ile osób posiada
            // nazwisko o podanej długości 
            //np:
            // nazwisko o długości 5 ma 4 osoby
            // nazwisko o długości 7 ma 6 osoby
            // nazwisko o długości 6 ma 6 osoby
            //.... itd..
            // wyniki posortuj po liczibie osób w grupie rosnąco
            // , a jeżeli liczba osób jest taka sama to po długości nazwiska malejąco

            // * uwzgędnij tylko zawodników, których nazwisko nie zaczyna się na "a"
            // i wypisz tylko te grupy, które zawierają co najmniej 2 osoby 

            var w13 = zawodnicy
                    .Where(x => !x.Nazwisko.StartsWith("a"))
                    .GroupBy(x => x.Nazwisko.Length)
                    .Select(x => new
                    {
                        DlugoscNazwiska = x.Key,
                        LiczbaOsob = x.Count()
                    })
                    .Where(x => x.LiczbaOsob > 1)
                    .OrderBy(x => x.LiczbaOsob)
                    .ThenByDescending(x => x.DlugoscNazwiska)
                    .ToArray();

            foreach (var g in w13)
                Console.WriteLine($"nazwisko o długości {g.DlugoscNazwiska} ma {g.LiczbaOsob} osoby");

            /*
             * select len(nazwisko) dl, count(*) liczbaOsob
                from zawodnicy
                where left(nazwisko,1) != 'a'
                group by len(nazwisko) 
                having count(*) > 1
                order by liczbaOsob, dl desc
            */


            // znajdz 1 zawodnika dokładnie małysza 

            Zawodnik w14 = zawodnicy.Where(x => x.Nazwisko.ToLower() == "małysz").ToArray()[0];

            Zawodnik w15 = zawodnicy.Where(x => x.Nazwisko.ToLower() == "małysz").FirstOrDefault();

            Zawodnik w16 = zawodnicy.FirstOrDefault(x => x.Nazwisko.ToLower() == "małysz");

            Zawodnik w17 = zawodnicy.FirstOrDefault(x => x.Id_zawodnika == 5);

            // znajdz zawodnikow ktroych waga jest o dokładnie 1 kilogram mniejsza o wagi najwyższego zawodnika

            var najwyszy = zawodnicy.OrderByDescending(x => x.Wzrost).FirstOrDefault();

            var w18 = zawodnicy.Where(x => x.Waga == najwyszy.Waga - 1).ToArray();

            // inne rozwiazanie
            var w19 = zawodnicy.Where(x => x.Waga == zawodnicy.OrderByDescending(y => y.Wzrost).FirstOrDefault().Waga - 1).ToArray();

            // inne rozwiazanie 
            var najwyzszy2 = zawodnicy.Select(x => x.Wzrost).Max();
            
            var w20 = zawodnicy
                .Where(x => 
                    x.Waga == zawodnicy.FirstOrDefault(y=>
                        y.Wzrost == zawodnicy.Select(z => 
                            z.Wzrost).Max()).Waga - 1).ToArray();

            // dla każdego kraju wypisz imie i nazwisko najwyzszego zawodnika z tego kraju 
            zawodnicy.GroupBy(x => x.Kraj)
                    .Select(x => new
                    {
                        Kraj = x.Key,
                        x.OrderByDescending(y => y.Wzrost).FirstOrDefault().ImieNazwisko
                    }).ToArray();

            // wypiz grupy nazwisk zawodnikow uruodznych w tym samym miesiacu 

            //przykłądowy wynik:
            // 1 : małysz, herr
            // 2 : bachleda, ....

            var wyn21=zawodnicy
                .GroupBy(x => x.DataUrodzenia.Month)
                .Select(x => new
                {
                    NrMiesiaca = x.Key,
                    Nazwiska = string.Join(", ", x.Select(y => y.Nazwisko).ToArray())
                })
                .OrderBy(x=>x.NrMiesiaca)
                .ToArray();

            foreach (var item in wyn21)
                Console.WriteLine(
                    
                   new DateTime(2000,item.NrMiesiaca,1).ToString("MMMM")
                    
                    + " : " + item.Nazwiska);


            Console.ReadKey();
        }
    }
}
