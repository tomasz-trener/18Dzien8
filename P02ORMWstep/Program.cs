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
            Zawodnik[] w1 = db.Zawodniks.ToArray();

            foreach (var z in w1)
            {
                Console.WriteLine(z.imie + " " + z.nazwisko);
            }

            Console.ReadKey();
        }
    }
}
