namespace P01AplikacjaZawodnicy
{
    partial class FrmZawodnicy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtParamPolaczenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnSrednieWzrosty = new System.Windows.Forms.Button();
            this.rbPlik = new System.Windows.Forms.RadioButton();
            this.rbBaza = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMiasta = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            this.wbRaport = new System.Windows.Forms.WebBrowser();
            this.chWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStworzWykres = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParamPolaczenia
            // 
            this.txtParamPolaczenia.Location = new System.Drawing.Point(123, 28);
            this.txtParamPolaczenia.Name = "txtParamPolaczenia";
            this.txtParamPolaczenia.Size = new System.Drawing.Size(241, 20);
            this.txtParamPolaczenia.TabIndex = 0;
            this.txtParamPolaczenia.Text = "Data Source=.;Initial Catalog=Zawodnicy;User ID=sa;Password=alx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parametr połączenia";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Enabled = false;
            this.btnWczytaj.Location = new System.Drawing.Point(370, 9);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 2;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Items.AddRange(new object[] {
            "ala",
            "ma",
            "kota"});
            this.lbDane.Location = new System.Drawing.Point(15, 52);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(349, 264);
            this.lbDane.TabIndex = 3;
            // 
            // btnSrednieWzrosty
            // 
            this.btnSrednieWzrosty.Enabled = false;
            this.btnSrednieWzrosty.Location = new System.Drawing.Point(370, 235);
            this.btnSrednieWzrosty.Name = "btnSrednieWzrosty";
            this.btnSrednieWzrosty.Size = new System.Drawing.Size(75, 38);
            this.btnSrednieWzrosty.TabIndex = 4;
            this.btnSrednieWzrosty.Text = "Średnie wzrosty";
            this.btnSrednieWzrosty.UseVisualStyleBackColor = true;
            this.btnSrednieWzrosty.Click += new System.EventHandler(this.btnSrednieWzrosty_Click);
            // 
            // rbPlik
            // 
            this.rbPlik.AutoSize = true;
            this.rbPlik.Location = new System.Drawing.Point(123, 5);
            this.rbPlik.Name = "rbPlik";
            this.rbPlik.Size = new System.Drawing.Size(42, 17);
            this.rbPlik.TabIndex = 5;
            this.rbPlik.Text = "Plik";
            this.rbPlik.UseVisualStyleBackColor = true;
            this.rbPlik.CheckedChanged += new System.EventHandler(this.rbPlik_CheckedChanged);
            // 
            // rbBaza
            // 
            this.rbBaza.AutoSize = true;
            this.rbBaza.Location = new System.Drawing.Point(171, 5);
            this.rbBaza.Name = "rbBaza";
            this.rbBaza.Size = new System.Drawing.Size(49, 17);
            this.rbBaza.TabIndex = 6;
            this.rbBaza.Text = "Baza";
            this.rbBaza.UseVisualStyleBackColor = true;
            this.rbBaza.CheckedChanged += new System.EventHandler(this.rbBaza_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Typ połączenia";
            // 
            // btnMiasta
            // 
            this.btnMiasta.Location = new System.Drawing.Point(370, 279);
            this.btnMiasta.Name = "btnMiasta";
            this.btnMiasta.Size = new System.Drawing.Size(75, 37);
            this.btnMiasta.TabIndex = 8;
            this.btnMiasta.Text = "Miasta";
            this.btnMiasta.UseVisualStyleBackColor = true;
            this.btnMiasta.Click += new System.EventHandler(this.btnMiasta_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(370, 52);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 38);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Enabled = false;
            this.btnEdytuj.Location = new System.Drawing.Point(370, 96);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 38);
            this.btnEdytuj.TabIndex = 10;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Enabled = false;
            this.btnUsun.Location = new System.Drawing.Point(370, 140);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 38);
            this.btnUsun.TabIndex = 11;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRaport.Location = new System.Drawing.Point(370, 184);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(75, 45);
            this.btnRaport.TabIndex = 12;
            this.btnRaport.Text = "Raport PDF";
            this.btnRaport.UseVisualStyleBackColor = false;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // wbRaport
            // 
            this.wbRaport.Location = new System.Drawing.Point(451, 52);
            this.wbRaport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbRaport.Name = "wbRaport";
            this.wbRaport.Size = new System.Drawing.Size(300, 264);
            this.wbRaport.TabIndex = 13;
            // 
            // chWykres
            // 
            chartArea2.Name = "ChartArea1";
            this.chWykres.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chWykres.Legends.Add(legend2);
            this.chWykres.Location = new System.Drawing.Point(766, 50);
            this.chWykres.Name = "chWykres";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chWykres.Series.Add(series2);
            this.chWykres.Size = new System.Drawing.Size(306, 266);
            this.chWykres.TabIndex = 14;
            this.chWykres.Text = "chart1";
            // 
            // btnStworzWykres
            // 
            this.btnStworzWykres.Location = new System.Drawing.Point(766, 21);
            this.btnStworzWykres.Name = "btnStworzWykres";
            this.btnStworzWykres.Size = new System.Drawing.Size(89, 23);
            this.btnStworzWykres.TabIndex = 15;
            this.btnStworzWykres.Text = "Wykres";
            this.btnStworzWykres.UseVisualStyleBackColor = true;
            this.btnStworzWykres.Click += new System.EventHandler(this.btnStworzWykres_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStworzWykres);
            this.Controls.Add(this.chWykres);
            this.Controls.Add(this.wbRaport);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnMiasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbBaza);
            this.Controls.Add(this.rbPlik);
            this.Controls.Add(this.btnSrednieWzrosty);
            this.Controls.Add(this.lbDane);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParamPolaczenia);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParamPolaczenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnSrednieWzrosty;
        private System.Windows.Forms.RadioButton rbPlik;
        private System.Windows.Forms.RadioButton rbBaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMiasta;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.WebBrowser wbRaport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chWykres;
        private System.Windows.Forms.Button btnStworzWykres;
        private System.Windows.Forms.Button button1;
    }
}

