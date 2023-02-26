 
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
        private Miasto[] tablicaMiast;
        

        public Miasto[] TablicaMiast
        {
            get{ return tablicaMiast; }
        }

        public ManagerMiast(string connString)
        {
            this.connString = connString;
            
        }


        public void WczytajMiasta()
        {
            throw new NotImplementedException();
            //     tablicaMiast = ....;
        }

        public void Usun(int id)
        {
            throw new NotImplementedException();
        }

        public void Edytuj(Miasto m)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Miasto m)
        {
            throw new NotImplementedException();
        }

    }
}
