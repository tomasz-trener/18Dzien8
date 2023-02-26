
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace P01AplikacjaZawodnicy
{
    public enum SposobPolaczenia
    {
        BazaDanych,
        Plik
    }
    public class ManagerZawodnikow
    {
        private string url;
        private string connString;
        private Zawodnik[] tablicaZawodnikow;
        private const string naglowek = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga";
        Zawodnik[] zawodnicyKraju;
        SposobPolaczenia sposobPolaczenia;
     

        /// <summary>
        /// Tworzy nowy menager zawodników zgodnie z wybranym sposoblem połączenia
        /// </summary>
        /// <param name="sposobPolaczenia">Baza danych lub plik</param>
        /// <param name="parametrPolaczenia">Adres polaczenia do bazy lub adres pliku</param>
        /// <exception cref="Exception"></exception>
        public ManagerZawodnikow(SposobPolaczenia sposobPolaczenia, string parametrPolaczenia)
        {
            this.sposobPolaczenia = sposobPolaczenia;
            if (sposobPolaczenia == SposobPolaczenia.Plik)
                url = parametrPolaczenia;
            else if(sposobPolaczenia == SposobPolaczenia.BazaDanych)
                    connString = parametrPolaczenia;
            else
                throw new Exception("nieznany sposób polaczenia");

          
        }

        public Zawodnik[] TablicaZawodnikow
        {
            get { return tablicaZawodnikow; }
        }

        //public Zawodnik[] PodajZawodnikow()
        //{
        //    return tablicaZawodnikow;
        //}


        public void WczytajZawodnikow()
        {
            if (sposobPolaczenia == SposobPolaczenia.BazaDanych)
                wczytajZawodnikowZBazy();
            else if (sposobPolaczenia == SposobPolaczenia.Plik)
                wczytajZawodnikowZpliku();
            else
                throw new Exception("nieznany sposób polaczenia");
        }

        private void wczytajZawodnikowZBazy()
        {
            throw new NotImplementedException();
            // do uzupełnienia 
            // tablicaZawodnikow = ....
        }

        private void wczytajZawodnikowZpliku()
        {
            string dane = new WebClient().DownloadString(url);
            string[] separatory = { "\r\n" };
            string[] wiersze = dane.Split(separatory, StringSplitOptions.RemoveEmptyEntries);
            
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

            for (int i = 1; i < wiersze.Length; i++) 
            {
                string[]komorki = wiersze[i].Split(';');
                Zawodnik z = new Zawodnik();

                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);
                zawodnicy.Add(z);               
            }
            tablicaZawodnikow = zawodnicy.ToArray();        
        }

      
        public string PodajLiczbeZawodnikowZDanegoKraju(string kraj)
        {
            throw new NotImplementedException();
            // do uzupelnienia 
        }

        public GrupaKraju[] PodajSredniWzrostZawodnikowDlaKazdegoKraju()
        {
            throw new NotImplementedException();
            // do uzupełenia 

        }

        public void ZnajdzZawodnikow(string kraj)
        {
            throw new NotImplementedException();
            // zawodnicyKraju = ....;
        }

        public void ZapiszPlik(string sciezka)
        {
            StringBuilder sb = new StringBuilder(naglowek + Environment.NewLine);
            
                foreach(var w in zawodnicyKraju) 
                {
                    sb.AppendLine(
                        $"{w.Id_zawodnika};{w.Id_trenera};{w.Imie}" +
                        $"{w.Nazwisko};{w.Kraj};{w.DataUrodzenia.ToString("yyyy-MM-dd")};" +
                        $"{w.Wzrost};{w.Waga}"
                        );
                }

            File.WriteAllText(sciezka, sb.ToString());                                                         
        }

        public void Usun(int id)
        {
            throw new NotImplementedException();
        }

        public void Edytuj(Zawodnik z)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Zawodnik z)
        {
            throw new NotImplementedException();
        }
    }
}
