﻿namespace AplikacijaZaRestoran
{
    partial class Pocetna
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salate = new System.Windows.Forms.Button();
            this.glJelo = new System.Windows.Forms.Button();
            this.predjelo = new System.Windows.Forms.Button();
            this.juha = new System.Windows.Forms.Button();
            this.desert = new System.Windows.Forms.Button();
            this.alkPica = new System.Windows.Forms.Button();
            this.bezAlkPica = new System.Windows.Forms.Button();
            this.kave = new System.Windows.Forms.Button();
            this.stolovi = new System.Windows.Forms.ComboBox();
            this.narudzba = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.proizvodi = new System.Windows.Forms.GroupBox();
            this.ispisRac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iznos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salate);
            this.groupBox1.Controls.Add(this.glJelo);
            this.groupBox1.Controls.Add(this.predjelo);
            this.groupBox1.Controls.Add(this.juha);
            this.groupBox1.Controls.Add(this.desert);
            this.groupBox1.Controls.Add(this.alkPica);
            this.groupBox1.Controls.Add(this.bezAlkPica);
            this.groupBox1.Controls.Add(this.kave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 460);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // salate
            // 
            this.salate.Location = new System.Drawing.Point(166, 345);
            this.salate.Name = "salate";
            this.salate.Size = new System.Drawing.Size(126, 84);
            this.salate.TabIndex = 15;
            this.salate.Text = "Salata";
            this.salate.UseVisualStyleBackColor = true;
            // 
            // glJelo
            // 
            this.glJelo.Location = new System.Drawing.Point(166, 235);
            this.glJelo.Name = "glJelo";
            this.glJelo.Size = new System.Drawing.Size(126, 84);
            this.glJelo.TabIndex = 14;
            this.glJelo.Text = "Glavno jelo";
            this.glJelo.UseVisualStyleBackColor = true;
            // 
            // predjelo
            // 
            this.predjelo.Location = new System.Drawing.Point(166, 132);
            this.predjelo.Name = "predjelo";
            this.predjelo.Size = new System.Drawing.Size(126, 84);
            this.predjelo.TabIndex = 13;
            this.predjelo.Text = "Predjelo";
            this.predjelo.UseVisualStyleBackColor = true;
            // 
            // juha
            // 
            this.juha.Location = new System.Drawing.Point(166, 26);
            this.juha.Name = "juha";
            this.juha.Size = new System.Drawing.Size(126, 84);
            this.juha.TabIndex = 12;
            this.juha.Text = "Juha";
            this.juha.UseVisualStyleBackColor = true;
            // 
            // desert
            // 
            this.desert.Location = new System.Drawing.Point(20, 345);
            this.desert.Name = "desert";
            this.desert.Size = new System.Drawing.Size(126, 84);
            this.desert.TabIndex = 11;
            this.desert.Text = "Desert";
            this.desert.UseVisualStyleBackColor = true;
            // 
            // alkPica
            // 
            this.alkPica.Location = new System.Drawing.Point(20, 235);
            this.alkPica.Name = "alkPica";
            this.alkPica.Size = new System.Drawing.Size(126, 84);
            this.alkPica.TabIndex = 10;
            this.alkPica.Text = "Alkoholna pića";
            this.alkPica.UseVisualStyleBackColor = true;
            // 
            // bezAlkPica
            // 
            this.bezAlkPica.Location = new System.Drawing.Point(20, 132);
            this.bezAlkPica.Name = "bezAlkPica";
            this.bezAlkPica.Size = new System.Drawing.Size(126, 84);
            this.bezAlkPica.TabIndex = 9;
            this.bezAlkPica.Text = "Bezalkoholna pića";
            this.bezAlkPica.UseVisualStyleBackColor = true;
            // 
            // kave
            // 
            this.kave.Location = new System.Drawing.Point(20, 26);
            this.kave.Name = "kave";
            this.kave.Size = new System.Drawing.Size(126, 84);
            this.kave.TabIndex = 8;
            this.kave.Text = "Kava";
            this.kave.UseVisualStyleBackColor = true;
            // 
            // stolovi
            // 
            this.stolovi.FormattingEnabled = true;
            this.stolovi.Items.AddRange(new object[] {
            "Dodaj novi stol"});
            this.stolovi.Location = new System.Drawing.Point(804, 12);
            this.stolovi.Name = "stolovi";
            this.stolovi.Size = new System.Drawing.Size(268, 21);
            this.stolovi.TabIndex = 0;
            // 
            // narudzba
            // 
            this.narudzba.ColumnHeadersHeight = 25;
            this.narudzba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.kolicina,
            this.cijena,
            this.izbrisi});
            this.narudzba.Location = new System.Drawing.Point(804, 58);
            this.narudzba.Name = "narudzba";
            this.narudzba.RowHeadersVisible = false;
            this.narudzba.RowHeadersWidth = 40;
            this.narudzba.Size = new System.Drawing.Size(268, 320);
            this.narudzba.TabIndex = 11;
            this.narudzba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            // 
            // kolicina
            // 
            this.kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // cijena
            // 
            this.cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            // 
            // izbrisi
            // 
            this.izbrisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.izbrisi.HeaderText = "Izbriši";
            this.izbrisi.Name = "izbrisi";
            // 
            // proizvodi
            // 
            this.proizvodi.Location = new System.Drawing.Point(344, 12);
            this.proizvodi.Name = "proizvodi";
            this.proizvodi.Size = new System.Drawing.Size(426, 460);
            this.proizvodi.TabIndex = 12;
            this.proizvodi.TabStop = false;
            // 
            // ispisRac
            // 
            this.ispisRac.Location = new System.Drawing.Point(804, 425);
            this.ispisRac.Name = "ispisRac";
            this.ispisRac.Size = new System.Drawing.Size(126, 47);
            this.ispisRac.TabIndex = 14;
            this.ispisRac.Text = "Ispiši račun";
            this.ispisRac.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Izbriši narudžbu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Iznos:";
            // 
            // iznos
            // 
            this.iznos.AutoSize = true;
            this.iznos.Location = new System.Drawing.Point(843, 393);
            this.iznos.Name = "iznos";
            this.iznos.Size = new System.Drawing.Size(46, 13);
            this.iznos.TabIndex = 17;
            this.iznos.Text = "0,00 KN";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 484);
            this.Controls.Add(this.iznos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ispisRac);
            this.Controls.Add(this.proizvodi);
            this.Controls.Add(this.narudzba);
            this.Controls.Add(this.stolovi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pocetna";
            this.Text = "Početna stranica";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.narudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button salate;
        private System.Windows.Forms.Button glJelo;
        private System.Windows.Forms.Button predjelo;
        private System.Windows.Forms.Button juha;
        private System.Windows.Forms.Button desert;
        private System.Windows.Forms.Button alkPica;
        private System.Windows.Forms.Button bezAlkPica;
        private System.Windows.Forms.Button kave;
        private System.Windows.Forms.ComboBox stolovi;
        private System.Windows.Forms.DataGridView narudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewButtonColumn izbrisi;
        private System.Windows.Forms.GroupBox proizvodi;
        private System.Windows.Forms.Button ispisRac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iznos;
    }
}

