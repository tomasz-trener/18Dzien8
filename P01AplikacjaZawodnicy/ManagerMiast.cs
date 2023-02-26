 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy
{
    internal class ManagerMiast
    {

        private string connString;
        private MiastoVM[] tablicaMiast;
        

        public MiastoVM[] TablicaMiast
        {
            get{ return tablicaMiast; }
        }

        public ManagerMiast(string connString)
        {
            this.connString = connString;
            
        }


        public void WczytajMiasta()
        {
            ModelBazyDataContext db = new ModelBazyDataContext();

            tablicaMiast = db.Miasto.Select(x=>new MiastoVM()
            {
                Id = x.id_miasta,
                Nazwa = x.nazwa_miasta
            }).ToArray();
        }

        public void Usun(int id)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            var doUsuniecia = db.Miasto.FirstOrDefault(x => x.id_miasta == id);
            db.Miasto.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();
        }

        public void Edytuj(MiastoVM m)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            var doEdycji = db.Miasto.FirstOrDefault(x => x.id_miasta == m.Id);
            doEdycji.nazwa_miasta = m.Nazwa;
            db.SubmitChanges();
        }

        public void Dodaj(MiastoVM m)
        {
            ModelBazyDataContext db = new ModelBazyDataContext();
            Miasto nowe = new Miasto();
            nowe.nazwa_miasta = m.Nazwa;
            db.Miasto.InsertOnSubmit(nowe);
            db.SubmitChanges();
        }

    }
}
