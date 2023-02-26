using P01AplikacjaZawodnicy.Properties;
using P04ZadaniePogoda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P01AplikacjaZawodnicy
{
    public partial class FrmMiasta : Form
    {
        ManagerMiast mm;
        public FrmMiasta(string connString)
        {
            InitializeComponent();

            mm = new ManagerMiast(connString);
            Odswiez();
            //foreach (var m in mm.TablicaMiast)
            //{
            //    lbDane.Items.Add(m.Nazwa);
            //}
        }

        private void Odswiez()
        {
            mm.WczytajMiasta();

            lbDane.DataSource = mm.TablicaMiast;
            lbDane.DisplayMember = "Nazwa";

            string[] nazwyMiast = mm.TablicaMiast.Select(x => x.Nazwa).ToArray();
            ManagerPogody mp = new ManagerPogody();
            mp.Jednostka = 'c';
            double[] temp = new double[nazwyMiast.Length];
            for (int i = 0; i < nazwyMiast.Length; i++)
                temp[i] = mp.PodajTemperature(nazwyMiast[i]);

            chart1.Series.Clear();


             Series seriaDanych = new  Series("Miast");

            seriaDanych.ChartType = SeriesChartType.Column;

            seriaDanych.Points.DataBindXY(nazwyMiast, temp);

            chart1.Series.Add(seriaDanych);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            MiastoVM zaznaczone= (MiastoVM)lbDane.SelectedItem;
            mm.Usun(zaznaczone.Id);
            Odswiez();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            MiastoVM zaznaczone = (MiastoVM)lbDane.SelectedItem;
            zaznaczone.Nazwa = txtNazwaMiasta.Text;

            mm.Edytuj(zaznaczone);
            Odswiez();
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            MiastoVM zaznaczone = (MiastoVM)lbDane.SelectedItem;
            txtNazwaMiasta.Text = zaznaczone.Nazwa;

            ManagerPogody mp = new ManagerPogody();
            mp.Jednostka = 'c';

            txtTemperatura.Text = Convert.ToString(mp.PodajTemperature(zaznaczone.Nazwa));
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Czy chcesz dodac miasto?", "Pytanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MiastoVM nowe = new MiastoVM();
                nowe.Nazwa = txtNazwaMiasta.Text;

                mm.Dodaj(nowe);
                Odswiez();
            }
        }
    }
}
