namespace P01AplikacjaZawodnicy
{
    partial class FrmSzczegoly
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.dtpDataUr = new System.Windows.Forms.DateTimePicker();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.numWzrost = new System.Windows.Forms.NumericUpDown();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.pnlPolaZawodnika = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).BeginInit();
            this.pnlPolaZawodnika.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 25);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(217, 20);
            this.txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(12, 70);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(217, 20);
            this.txtNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(12, 117);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(217, 20);
            this.txtKraj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Waga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wzrost";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Enabled = false;
            this.btnZapisz.Location = new System.Drawing.Point(148, 342);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(83, 24);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // dtpDataUr
            // 
            this.dtpDataUr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUr.Location = new System.Drawing.Point(12, 162);
            this.dtpDataUr.Name = "dtpDataUr";
            this.dtpDataUr.Size = new System.Drawing.Size(217, 20);
            this.dtpDataUr.TabIndex = 13;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(12, 210);
            this.numWaga.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(217, 20);
            this.numWaga.TabIndex = 14;
            // 
            // numWzrost
            // 
            this.numWzrost.Location = new System.Drawing.Point(12, 256);
            this.numWzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numWzrost.Name = "numWzrost";
            this.numWzrost.Size = new System.Drawing.Size(217, 20);
            this.numWzrost.TabIndex = 15;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(15, 342);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 16;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // pnlPolaZawodnika
            // 
            this.pnlPolaZawodnika.Controls.Add(this.textBox1);
            this.pnlPolaZawodnika.Controls.Add(this.txtKraj);
            this.pnlPolaZawodnika.Controls.Add(this.label1);
            this.pnlPolaZawodnika.Controls.Add(this.numWzrost);
            this.pnlPolaZawodnika.Controls.Add(this.txtImie);
            this.pnlPolaZawodnika.Controls.Add(this.numWaga);
            this.pnlPolaZawodnika.Controls.Add(this.label2);
            this.pnlPolaZawodnika.Controls.Add(this.dtpDataUr);
            this.pnlPolaZawodnika.Controls.Add(this.txtNazwisko);
            this.pnlPolaZawodnika.Controls.Add(this.label3);
            this.pnlPolaZawodnika.Controls.Add(this.label6);
            this.pnlPolaZawodnika.Controls.Add(this.label4);
            this.pnlPolaZawodnika.Controls.Add(this.label5);
            this.pnlPolaZawodnika.Location = new System.Drawing.Point(12, 12);
            this.pnlPolaZawodnika.Name = "pnlPolaZawodnika";
            this.pnlPolaZawodnika.Size = new System.Drawing.Size(246, 324);
            this.pnlPolaZawodnika.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 381);
            this.Controls.Add(this.pnlPolaZawodnika);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).EndInit();
            this.pnlPolaZawodnika.ResumeLayout(false);
            this.pnlPolaZawodnika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DateTimePicker dtpDataUr;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.NumericUpDown numWzrost;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Panel pnlPolaZawodnika;
        private System.Windows.Forms.TextBox textBox1;
    }
}