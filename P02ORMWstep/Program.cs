using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ORMWstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
          //  Zawodnik[] w1 = db.Zawodniks.ToArray();

            var w2=
                db.Zawodnik
                    .GroupBy(x => x.kraj)
                    .Select(x => new
                    {
                        Kraj = x.Key,
                        SredniWzrost = x.Average(y => y.wzrost)
                    }).ToArray();


            //foreach (var z in w1)
            //{
            //    Console.WriteLine(z.imie + " " + z.nazwisko);
            //}


            // dodawanie danych do bazy 

            //Zawodnik nowy = new Zawodnik()
            //{
            //    imie = "adam",
            //    nazwisko = "nowak",
            //    waga = 70,
            //    wzrost = 180,
            //    kraj = "pol",
            //    data_ur = new DateTime(2000, 2, 4)
            //};

            //db.Zawodnik.InsertOnSubmit(nowy);
            //db.SubmitChanges();

            // edycja 
            //var doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 19);
            //doEdycji.imie = "Lukasz";
            //doEdycji.kraj = "AUT";
            //db.SubmitChanges();


            // usuwanie 
            var doUsuniecia = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 19);
            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();



            Console.ReadKey();
        }
    }
}
