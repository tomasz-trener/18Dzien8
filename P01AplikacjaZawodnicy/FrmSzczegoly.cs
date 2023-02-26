using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {
        Zawodnik zawodnik;
        ManagerZawodnikow mz;
        FrmZawodnicy frmZawodnicy;

        public FrmSzczegoly(ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
            dodajZdarzeniaDoTextboxow();
            this.mz = mz;
            this.frmZawodnicy = frmZawodnicy;

           // string conn = frmZawodnicy.TxtParamPolaczenia.Text;
        }

        public FrmSzczegoly(Zawodnik zawodnik, ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy)
        {
            InitializeComponent();
            dodajZdarzeniaDoTextboxow();
            this.mz = mz;
            this.zawodnik = zawodnik;
            this.frmZawodnicy = frmZawodnicy;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;

            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
        }

        private void dodajZdarzeniaDoTextboxow()
        {
            foreach (var item in pnlPolaZawodnika.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).TextChanged += new EventHandler(txtTextChange);
                }
            }
        }

        // walidacja textboxow 
        private void txtTextChange(object sender, EventArgs e)
        {
            btnZapisz.Enabled = true;
            foreach (var item in pnlPolaZawodnika.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)item).Text))
                    {
                        btnZapisz.Enabled = false;
                    }
                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e) 
        {
            DialogResult dr=
                MessageBox.Show("Czy napewno chcesz zapisac zmiany? ", "Pytanie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                if (zawodnik == null) // tryb dodawania
                {
                    zawodnik = new Zawodnik();
                    ZczytajDane();
                    mz.Dodaj(zawodnik);
                }
                else // tryb edycji 
                {
                    ZczytajDane();
                    mz.Edytuj(zawodnik);
                }
                
              
                frmZawodnicy.Odswiez();
                this.Close();
            }



        }

        private void ZczytajDane()
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUrodzenia = dtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
