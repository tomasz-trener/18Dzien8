using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadaniePogoda
{
    internal class ManagerPogody
    {

        public char Jednostka { get; set; }

        private const string szukanyZnak = "°";
        private const string znakKoncowy = ">";
        private const string url = "https://www.google.com/search?q=pogoda+";
        // do czego sluza pola np:
        // - przechowywanie prywatnych stałych 

        public double PodajTemperature(string miasto/*, char jedn*/)
        {
            //string url = $"https://www.google.com/search?q=pogoda+{miasto}";
            string dane = new WebClient().DownloadString(url+ miasto);
            //   Console.WriteLine(dane);
            //File.WriteAllText("c:\\dane\\strona.html", dane);

            int indx = dane.IndexOf(szukanyZnak);
            int aktualnaPozycja = indx;

            while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                aktualnaPozycja--; // zmniejsz o 1     aktualnapozycja = atktualnapozycja - 1

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

            int w= Convert.ToInt32(wynik.Substring(0,wynik.Length-2));

            return TransformujTemperature(/*jedn,*/ w);
        }

        private double TransformujTemperature(/*char jedn,*/ int temp) 
        {
            if (Jednostka == 'c')
                return temp;

            if (Jednostka == 'f')
                return temp * 1.8 + 32;

            if (Jednostka == 'k')
                return temp + 273.15;


            // return 0;
            // jak wiemy, ze coś jest nie tak
            // to rzuc błędem 
            throw new Exception("Nieznana jednostka");
        }


        // dodaj opcje aby mozna bylo podac 
        // temeprature w roznych jednostkach:
        // celcjusz, farenheit lub kelvin
    }
}
