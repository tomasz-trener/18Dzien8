
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
    public partial class FrmZawodnicy : Form
    {
        ManagerZawodnikow mz;

        public TextBox TxtParamPolaczenia 
        { 
            get
            {
                return txtParamPolaczenia;
            } 
        }

        public FrmZawodnicy()
        {
            InitializeComponent(); 
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            aktywujPrzyciski();
            ustawManagerZawodnikow();
            Odswiez();
        }

        public void Odswiez()
        {
            mz.WczytajZawodnikow();
            // tutaj chce miec tych zawodnikach
            Zawodnik[] zawodnicy = mz.TablicaZawodnikow;
           
            // lbDane.Items.Clear();
            //for (int i = 0; i < zawodnicy.Length; i++)
            //{
            //    lbDane.Items.Add(zawodnicy[i].Imie + " " + zawodnicy[i].Nazwisko);
            //}


            //foreach (var z in zawodnicy)
            //    lbDane.Items.Add(  z.Imie + " " + z.Nazwisko);

            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void btnSrednieWzrosty_Click(object sender, EventArgs e)
        {
            GrupaKraju[] grupy= mz.PodajSredniWzrostZawodnikowDlaKazdegoKraju();
            FrmGrupyKrajow frmGrupyKrajow = new FrmGrupyKrajow(grupy);
            frmGrupyKrajow.Show();
        }

        private void aktywujPrzyciski()
        {
            btnWczytaj.Enabled = btnSrednieWzrosty.Enabled = true;
            btnDodaj.Enabled = true;
            btnEdytuj.Enabled = true;
            btnUsun.Enabled = true;
        }

        private void ustawManagerZawodnikow()
        {
            if (rbBaza.Checked)
                mz = new ManagerZawodnikow(SposobPolaczenia.BazaDanych, txtParamPolaczenia.Text);
            else
                mz = new ManagerZawodnikow(SposobPolaczenia.Plik, txtParamPolaczenia.Text);
        }

        private void rbPlik_CheckedChanged(object sender, EventArgs e)
        {
            btnWczytaj.Enabled = true;
            //  aktywujPrzyciski();
        }

        private void rbBaza_CheckedChanged(object sender, EventArgs e)
        {
            btnWczytaj.Enabled = true;
            //   aktywujPrzyciski();
        }

        private void btnMiasta_Click(object sender, EventArgs e)
        {
            FrmMiasta frmMiasta = new FrmMiasta(txtParamPolaczenia.Text);
            frmMiasta.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;
            mz.Usun(zaznaczony.Id_zawodnika);
            Odswiez();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {     
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(zaznaczony,mz,this);
            frmSzczegoly.Show();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(mz, this);
            frmSzczegoly.Show();
        }

   

        private void btnRaport_Click(object sender, EventArgs e)
        {
            PDFManager pm = new PDFManager(mz.TablicaZawodnikow);
            string filename = DateTime.Now.ToString("yyyyMMddmmss") + "raport.pdf";
            

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "c:\\dane";
            sfd.Title = "Wskaz miejsce zapisu pliku";
            sfd.Filter = "Plik PDF (*.pdf)|*.pdf";
            sfd.FileName = filename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pm.StworzPdf(sfd.FileName);
                wbRaport.Navigate(sfd.FileName);
            }
            

            //podaje sciezke do folder u gdzie znajduje sie exe 
           // string folder= AppDomain.CurrentDomain.BaseDirectory;
           // wbRaport.Navigate(folder+filename); 
            // navigate dziala wsposob specyficzny,
            // tzn wymaga od nas poadania plenej sciezki 
        }

        private void btnStworzWykres_Click(object sender, EventArgs e)
        {
            chWykres.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series seriaDanych = 
                new System.Windows.Forms.DataVisualization.Charting.Series("Wzrosty");

            seriaDanych.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            GrupaKraju[] gk= mz.PodajSredniWzrostZawodnikowDlaKazdegoKraju();

            gk = gk.OrderByDescending(x => x.SredniWzrost).ToArray();
            string[] osX = new string[gk.Length];
            double[] osY = new double[gk.Length];

            

            for (int i = 0; i < gk.Length; i++)
            {
                osX[i] = gk[i].Kraj;
                osY[i] = gk[i].SredniWzrost;
            }

            // string[] osX = { "pol", "ger" };
            // double[] osY = { 45.23, 53.32 };
            seriaDanych.Points.DataBindXY(osX, osY);

            chWykres.Series.Add(seriaDanych);

        }
    }
}
